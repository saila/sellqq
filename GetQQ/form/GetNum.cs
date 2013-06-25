using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetQQ.services;
using GetQQ.util;
using GetQQ.pojo;


namespace GetQQ.form
{
    public partial class GetNum : Form
    {
        private Form fatherForm;
        private DataTable dt;//下拉框数据源
        private string slid_v;//所属网页编号
        private string url;//所属网页地址
        private string title;//采集记录

        public GetNum(Form fatherForm,string slid_v,string url,string title)
        {
            InitializeComponent();
            this.slid_v = slid_v;
            this.url = url;
            this.title = title;
            this.Text = title;
            this.fatherForm = fatherForm;
        }

        private void GetNum_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            string[] cols = new string[] { "appvalues", "valuetype" };
            dt = salesscServices.getAll(cols);
            //获取wangwang下拉框数据
            DataGridViewComboBoxColumn cmbox = showNum.Columns["wwKehu"] as DataGridViewComboBoxColumn;//下拉框
            cmbox.DataSource = dt;
            cmbox.DisplayMember = "appvalues";
            cmbox.ValueMember = "appvalues";
            //设置交易状态下拉框数据
            DataTable dt_state = new DataTable();
            dt_state.Columns.Add("radio");
            DataRow row1 = dt_state.NewRow();
            DataRow row2 = dt_state.NewRow();
            DataRow row3 = dt_state.NewRow();
            row1["radio"] = "未出售";
            row2["radio"] = "交易中";
            row3["radio"] = "已卖出";
            dt_state.Rows.Add(row1);
            dt_state.Rows.Add(row2);
            dt_state.Rows.Add(row3);
            DataGridViewComboBoxColumn cmbox2 = showNum.Columns["radio"] as DataGridViewComboBoxColumn;//下拉框
            cmbox2.DataSource = dt_state;
            cmbox2.DisplayMember = "radio";
            cmbox2.ValueMember = "radio";
            //取得源码中的数据
            string value = Util.getHtml(url).Document.Body.InnerText.Replace("/", "").Replace("\\", "").Replace(" ", "");
            String[] values = value.Split('\n');
            rtb_show.Text = value;
            DataTable dt_new = new DataTable();
            dt_new.Columns.Add("cid");
            dt_new.Columns.Add("slid");
            dt_new.Columns.Add("srcRow");
            dt_new.Columns.Add("qqNum");
            dt_new.Columns.Add("price");
            dt_new.Columns.Add("qqLv");
            dt_new.Columns.Add("qqAge");
            dt_new.Columns.Add("qtid");
            dt_new.Columns.Add("radio");
            dt_new.Columns.Add("isFreeProtect");
            dt_new.Columns.Add("wwKehu");
            dt_new.Columns.Add("mima");
            foreach (string str in values)
            {
                if (str.Length > 5)
                {
                    string qqnum = RowParseUtil.getNum(str, true);
                    if (!qqnum.Equals("-"))
                    {
                        DataRow row = dt_new.NewRow();
                        row["cid"] = "";
                        row["slid"] = slid_v;
                        row["srcRow"] = str;
                        row["qqNum"] = qqnum;
                        try
                        {
                            row["price"] = Convert.ToInt32(RowParseUtil.getQQprice(str, qqnum));
                        }
                        catch (Exception)
                        {
                            row["price"] = -1;
                        }
                        try
                        {
                            row["qqLv"] = Convert.ToInt32(RowParseUtil.getQQLv(str));
                        }
                        catch (Exception)
                        {
                            row["qqLv"] = -1;
                        }
                        try
                        {
                            row["qqAge"] = Convert.ToInt32(RowParseUtil.getQQAge(str));
                        }
                        catch (Exception)
                        {
                            row["qqAge"] = -1;
                        }
                        switch (RowParseUtil.getQQType(str))
                        {
                            case 1:
                                row["qtid"] = "QQ号"; break;
                            case 3:
                                row["qtid"] = "QQ群号"; break;
                            case 5:
                                row["qtid"] = "QQ 连号"; break;
                            case 7:
                                row["qtid"] = "QQ群 连号"; break;
                            case 9:
                                row["qtid"] = "QQ 靓号"; break;
                            case 11:
                                row["qtid"] = "QQ群号 靓号"; break;
                            case 15:
                                row["qtid"] = "QQ群号 靓号 连号"; break;
                        }
                        row["radio"] = "未出售";
                        row["isFreeProtect"] = RowParseUtil.getIsFreeProtect(str);
                        row["wwKehu"] = "123456";
                        row["mima"] = "";
                        dt_new.Rows.Add(row);
                    }
                }
            }
            //绑定数据源
            showNum.DataSource = dt_new;
        }

        private void GetNum_FormClosed(object sender, FormClosedEventArgs e)
        {
            fatherForm.Show();
        }

        private void btn_saveNum_Click(object sender, EventArgs e)
        {
            //锁定 
            showNum.Enabled = false;
            //取得列表数据
            DataTable dt = (DataTable)showNum.DataSource;
            List<Contexts> ctss = new List<Contexts>();
            //遍历
            foreach (DataRow dr in dt.Rows) {
                Contexts cts = new Contexts();
                cts.slid = Convert.ToInt32(slid_v);
                cts.srcRow = dr["srcRow"].ToString();
                cts.qqNum = (long)Convert.ToDouble(dr["qqNum"].ToString());
                cts.price = Convert.ToDouble(dr["price"].ToString());
                cts.qqLv = Convert.ToInt32(dr["qqLv"].ToString());
                cts.qqAge = Convert.ToInt32(dr["qqAge"].ToString());
                switch (dr["qtid"].ToString())
                {
                    case "QQ号":
                        cts.qtid =1; break;
                    case "QQ群号":
                        cts.qtid = 3; break;
                    case "QQ 连号":
                        cts.qtid = 5; break;
                    case "QQ群 连号":
                        cts.qtid =7; break;
                    case "QQ 靓号":
                        cts.qtid =9; break;
                    case "QQ群号 靓号":
                        cts.qtid =11; break;
                    case "QQ群号 靓号 连号":
                        cts.qtid = 15; break;
                }
                cts.radio = dr["radio"].ToString();
                cts.isFreeProtect = Convert.ToBoolean(dr["isFreeProtect"].ToString());
                cts.wwKehu = dr["wwKehu"].ToString();
                cts.mima = dr["mima"].ToString();
                cts.isConn = 1;
                ctss.Add(cts);
            }
            ContextsServices.SaveSladdrList(ctss);
            MessageBox.Show("号码数据保存完毕");
            this.Close();
        }


    }
}
