using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetQQ.pojo;
using GetQQ.util;
using GetQQ.services;
using System.Net;
using GetQQ.form;

namespace GetQQ
{
    public partial class GetUrl : Form
    {
        private Form fatherForm;
        private DataSet ds;
        private Seller s;
        private bool hadSave = false;

        public GetUrl(Form fatherForm,DataSet ds,Seller s)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            this.ds = ds;
            this.s = s;
            fatherForm.Hide();
        }

        private void GetUrl_Load(object sender, EventArgs e)
        {
            //禁用采集按钮
            btn_allSave_getData.Enabled = false;
            //加载数据
            dgv_data.DataSource = ds.Tables[0];
            dgv_data.Columns["slid"].DataPropertyName = "slid";
            dgv_data.Columns["title"].DataPropertyName = "title";
            dgv_data.Columns["titleNote"].DataPropertyName = "titleNote";
            dgv_data.Columns["url"].DataPropertyName = "url";
        }

        private void GetUrl_FormClosed(object sender, FormClosedEventArgs e)
        {
            fatherForm.Show();
        }

        private void btn_allSave_Click(object sender, EventArgs e)
        {
            //锁定删除行 选择框
            nud_before.Enabled = false;
            nud_after.Enabled = false;
            delItem.Enabled = false;
            //锁定保存按钮
            btn_allSave.Enabled = false;
            //锁定显示table
            dgv_data.Enabled = false;
            //锁定右键菜单
            cms_dgv_data.Enabled = false;
            int lrow = Convert.ToInt32(nud_before.Value);
            int rrow = Convert.ToInt32(nud_after.Value);
            //保存dgv所有 二级网址 数据
            List<Sladdr> slas = new List<Sladdr>();
            DataTable dt = (DataTable)dgv_data.DataSource;
            foreach(DataRow dr in dt.Rows){
                Sladdr sladr = new Sladdr();
                sladr.title = dr["title"].ToString();
                sladr.titleNote = dr["titleNote"].ToString();
                sladr.url = dr["url"].ToString().Replace('\\','/');
                sladr.lrow = lrow;
                sladr.rrow = rrow;
                sladr.lastTime = DateTime.Now;
                slas.Add(sladr);
            }
            SladdrServies.SaveSladdrList(slas,s.sid);
            //解锁采集按钮
            //btn_allSave_getData.Enabled = true;
            hadSave = true;
            //解锁显示table
            dgv_data.Enabled = true;
            //解锁右键菜单
            cms_dgv_data.Enabled = true;
            //锁定修改  保护数据同步
            dgv_data.ReadOnly = true;
            //重新加载数据
            string[] cols = { "slid", "title", "titleNote", "url","state" };
            dgv_data.DataSource = SladdrServies.getAllByFields(cols, s.sid);
            dgv_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_allSave_getData_Click(object sender, EventArgs e)
        {
            //保存
            //btn_allSave_Click(null,null);
            //开始采集
        }

        private void getDataByThis_Click(object sender, EventArgs e)
        {
            if (!hadSave)
            { 
                //未保存
                MessageBox.Show("请先保存二级目录.");
                return;
            }
            //锁定全部保存按钮
            btn_allSave_getData.Enabled = false;
            //采集选中行数据
            if (dgv_data.SelectedCells.Count > 0)
            {
                //读取单元格的行索引删除
                Dictionary<Int32, Object> temp = new Dictionary<int, object>();
                for (int i = 0; i < this.dgv_data.SelectedCells.Count; i++)
                {
                    try
                    {
                        temp.Add(dgv_data.SelectedCells[i].RowIndex, null);
                    }
                    catch (Exception)
                    {
                        //忽略重复项
                    }
                }
                MessageBox.Show("共选中了" + temp.Keys.Count + "记录，确认采集");
                int total = temp.Keys.Count;
                int index =1;
                while (temp.Keys.Count > 0)
                {
                    string slid = dgv_data.Rows[temp.Keys.Max()].Cells["slid"].Value.ToString();
                    string url = dgv_data.Rows[temp.Keys.Max()].Cells["url"].Value.ToString();
                    if (url.IndexOf('.') > 0 && url.LastIndexOf('.') < url.Length - 1) { 
                        //url合法性 基本判断通过
                        try
                        {
                            if (url.IndexOf(".txt") == (url.Length - 4))
                            {
                                GetNum gn = new GetNum(this, slid, url, "第" + index + "个网页数据，共" + total + "个网页数据");
                                gn.ShowDialog();
                                index++;
                            }
                            else
                            {
                                //网页文件
                                string pageText = Util.getHtml(url).DocumentText;
                                //淘宝网站处理
                                if (url.ToLower().IndexOf("item.taobao.com") > -1)
                                {
                                    //截取出数据地址
                                    int startIndex = pageText.IndexOf("s.src=\"http://dsc.taobaocdn.com/") + 7;
                                    string newUrl = pageText.Substring(startIndex, 156);
                                    if (startIndex < 1) {
                                        int newIndex = pageText.IndexOf("data-url=\"")+10;
                                        newUrl = pageText.Substring(startIndex, 111);
                                    }
                                    //int endindex = pageText.IndexOf("\";document.getElementsByTagName('head')") - 1;
                                    GetNum gn = new GetNum(this, slid, newUrl, "第" + index + "个网页数据，共" + total + "个网页数据");
                                    gn.ShowDialog();
                                    index++;
                                }
                            }
                        }
                        catch (WebException webEx)
                        {
                            MessageBox.Show(webEx.Message.ToString());
                        }
                    }                        
                    this.dgv_data.Rows.Remove(this.dgv_data.Rows[temp.Keys.Max()]);
                    temp.Remove(temp.Keys.Max());
                    if (dgv_data.Rows.Count < 1) this.Close();
                }
            }
            //解锁全部采集按钮
            btn_allSave_getData.Enabled = true;
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            //删除选中行数据
            if (dgv_data.SelectedRows.Count > 0)
            {
                //直接删除行
                for (int i = 0; i < this.dgv_data.SelectedRows.Count; i++)
                {
                    this.dgv_data.Rows.Remove(this.dgv_data.SelectedRows[i]);
                }
            }
            else if (dgv_data.SelectedCells.Count > 0) {
                //读取单元格的行索引删除
                Dictionary<Int32, Object> temp = new Dictionary<int, object>();
                for (int i = 0; i < this.dgv_data.SelectedCells.Count; i++)
                {
                    try
                    {
                        temp.Add(dgv_data.SelectedCells[i].RowIndex, null);
                    }
                    catch (Exception ) {
                        //忽略重复项
                    }
                }
                MessageBox.Show("共选中了"+temp.Keys.Count+"记录，确认删除");
                while (temp.Keys.Count > 0) {
                    this.dgv_data.Rows.Remove(this.dgv_data.Rows[temp.Keys.Max()]);
                    temp.Remove(temp.Keys.Max());
                }
            }
            else
            {
                MessageBox.Show("你没有选中记录");
            }
        }

        private void cms_dgv_data_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
