using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using GetQQ.util;
using GetQQ.pojo;
using GetQQ.services;
using GetQQ.form;

namespace GetQQ
{
    public partial class MainForm : Form
    {
        private string sid = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            //锁定按钮
            btn_add.Enabled = false;
            //封装数据
            String sname = txt_sName.Text;
            String sww = txt_sWW.Text;
            String sqq = txt_sQQ.Text;
            String sphone = txt_sPhone.Text;
            String stypeName = txt_typeName.Text;
            string sinurl = rtb_urls.Text;//.Replace("/","&left;").Replace("\\","&right;");
            Seller seller = new Seller(sww, sname, sphone, sqq, stypeName, sinurl);
            //屏蔽操作界面
            Panel p = new Panel();
            p.Size = new Size(600, 600);
            p.Location = new Point(0, 0);
            //调用业务层 保存到数据库
            if (sid != null)
            {
                //更新
                seller.sid = Convert.ToInt32(this.sid);
                SellerServices.update(seller);
                sid = null;
            }
            else
            {
                //新增
                seller.sid = SellerServices.saveSeller(seller);
                MessageBox.Show(seller.sid+"-");
                //解析出二级地址
                String[] urls = rtb_urls.Lines;
                List<Sladdr> slas = new List<Sladdr>();
                for (int i = 0; i < urls.Length; i++)
                {
                    String url = urls[i];
                    if (url == null || url.Length < 1) continue;
                    if (url.ToLower().IndexOf("file:///") == 0)
                    {
                        //本地文件
                        try
                        {
                            DirectoryInfo TheFolder = new DirectoryInfo(url.Substring(8));
                            foreach (FileInfo NextFile in TheFolder.GetFiles())
                            {
                                slas.Add(new Sladdr(NextFile.Name, NextFile.FullName));
                            }
                        }
                        catch (Exception) { 
                            //忽略不存在的路径
                        }
                    }
                    else
                    {
                        //网页文件
                        WebBrowser wb = new WebBrowser();
                        wb.Navigate(new Uri(url));
                        wb.ScriptErrorsSuppressed = true; //不显示ScriptErrors
                        while (wb.ReadyState != WebBrowserReadyState.Complete)
                        {
                            Application.DoEvents();
                        }
                        Boolean isFilter = url.IndexOf("paipai.com") > -1 || url.IndexOf("taobao.com") > -1;
                        foreach (HtmlElement he in wb.Document.GetElementsByTagName("a"))
                        {
                            String title = he.InnerText;
                            String urlstr = he.GetAttribute("href");
                            //如果是淘宝网 或者 拍拍网，进行初步过滤
                            if (title != null && title.Trim().Length > 0)
                            {
                                if (title.IndexOf("刷新") > -1) continue;
                                if (title.IndexOf("上一步") > -1) continue;
                                if (title.IndexOf("下一步") > -1) continue;
                                if (isFilter)
                                {
                                    if (urlstr.IndexOf("item.taobao.com") > -1
                                        || urlstr.IndexOf("auction1.paipai.com") > -1)
                                    {
                                        slas.Add(new Sladdr(title, urlstr));
                                    }
                                }
                                else
                                {
                                    slas.Add(new Sladdr(title, urlstr));
                                }
                            }
                        }
                    }
                }
                //封装数据
                DataTable dt = new DataTable();
                dt.Columns.Add("slid");
                dt.Columns.Add("title");
                dt.Columns.Add("titleNote");
                dt.Columns.Add("url");
                dt.Columns.Add("state");
                foreach (Sladdr sla in slas)
                {
                    DataRow row = dt.NewRow();
                    row["slid"] = "";
                    row["title"] = sla.title;
                    row["titleNote"] = sla.titleNote;
                    row["url"] = sla.url;
                    row["state"] = "未保存";
                    dt.Rows.Add(row);
                }
                MessageBox.Show(dt.Rows.Count+"");
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);
                //打开二级目录管理窗口
                GetUrl gu = new GetUrl(this, ds,seller);
                gu.ShowDialog();
            }
            //清空数据
            txt_sName.Text = "";
            txt_sWW.Text = "";
            txt_sQQ.Text = "";
            txt_sPhone.Text = "";
            txt_typeName.Text = "";
            rtb_urls.Text = "";
            //解锁按钮
            btn_add.Enabled = true;
            MainForm_Load(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] cols = { "tsid", "tsWwNum", "tsName", "tsPhone", "tsQQ", "ttypeName", "turlIn" };
            //加载卖家数据
            DataTable dt = SellerServices.getAll(cols);
            if (dt.Rows.Count < 1) return;
            dgv_sellers.DataSource = dt;
            dgv_sellers.Columns[0].DataPropertyName = "tsid";
            dgv_sellers.Columns[1].DataPropertyName = "tsWwNum";
            dgv_sellers.Columns[2].DataPropertyName = "tsName";
            dgv_sellers.Columns[3].DataPropertyName = "tsPhone";
            dgv_sellers.Columns[4].DataPropertyName = "tsQQ";
            dgv_sellers.Columns[5].DataPropertyName = "ttypeName";
            dgv_sellers.Columns[6].DataPropertyName = "turlIn";
            dgv_sellers.CurrentCell = dgv_sellers.Rows[0].Cells[0];
        }

        private void edit_Click(object sender, EventArgs e)
        {
            //编辑卖家数据
            sid = dgv_sellers.SelectedRows[0].Cells[0].Value.ToString();
            txt_sWW.Text = dgv_sellers.SelectedRows[0].Cells[1].Value.ToString();
            txt_sName.Text = dgv_sellers.SelectedRows[0].Cells[2].Value.ToString();
            txt_sPhone.Text = dgv_sellers.SelectedRows[0].Cells[3].Value.ToString();
            txt_sQQ.Text = dgv_sellers.SelectedRows[0].Cells[4].Value.ToString();
            txt_typeName.Text=dgv_sellers.SelectedRows[0].Cells[5].Value.ToString();
            rtb_urls.Text = dgv_sellers.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void manage_Click(object sender, EventArgs e)
        {
            //管理二级目录
            int sid = Convert.ToInt32(dgv_sellers.SelectedRows[0].Cells[0].Value.ToString());
            Seller seller = new Seller();
            seller.sid = sid;
            ManageUrl mu = new ManageUrl(this, seller);
            mu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myFind find = new myFind();
            find.Show();
        }
    }
}
