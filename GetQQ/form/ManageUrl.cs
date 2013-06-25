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
    public partial class ManageUrl : Form
    {
        private Form fatherForm;
        private Seller s;

        public ManageUrl(Form fatherForm,Seller s)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            this.s = s;
            fatherForm.Hide();
        }

        private void GetUrl_Load(object sender, EventArgs e)
        {
            //禁用采集按钮
            btn_allSave_getData.Enabled = false;
            //加载数据
            string[] cols = { "slid", "title", "titleNote", "url","state" };
            MessageBox.Show(s.sid+"");
            dgv_data.DataSource = SladdrServies.getAllByFields(cols, s.sid);
        }

        private void GetUrl_FormClosed(object sender, FormClosedEventArgs e)
        {
            fatherForm.Show();
        }

        private void btn_allSave_Click(object sender, EventArgs e)
        {
            //扫描7天以上未更新数据
        }

        private void btn_allSave_getData_Click(object sender, EventArgs e)
        {
            //更新所有数据
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

        private void btn_saveEdit_Click(object sender, EventArgs e)
        {
            //保存更改
        }

        private void dgv_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
