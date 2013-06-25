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
using MySql.Data.MySqlClient;


namespace GetQQ.form
{
    public partial class Set : Form
    {
        public Set()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FindQQsevice.Sqldata(this.textlength.Text,
                this.textprice.Text,
                this.textlevel.Text,
                this.textQage.Text,
                this.textisconnum.Text,
                this.textyear.Text,
                this.textmonth.Text,
                this.textday.Text);
            MessageBox.Show("保存成功！");
        }

        private void Set_Load(object sender, EventArgs e)
        {
            string[] data = FindQQsevice.GetSetData();
            this.textlength.Text=data[0];
            this.textlevel.Text = data[1];
            this.textprice.Text = data[2];
            this.textQage.Text = data[3];
            this.textisconnum.Text = data[4];
            this.textyear.Text = data[5];
            this.textmonth.Text = data[6];
            this.textday.Text = data[7];
        }
    }
}
