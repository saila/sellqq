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
    public partial class myFind : Form
    {
        public myFind()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string length = "0-99";
            string price = "0-99999";
            string level="0";
            string regex = SearchText.Text.Trim();
            FindQQsevice.find += new delegateFindprogress(FindQQsevice_find);
            FindQQsevice.findother += new delegateFindprogress(FindQQsevice_findother);
            if (lengthbox.Text.Trim() != "")
                length = lengthbox.Text.Trim();
            if (priceBox.Text.Trim() != "")
                price = priceBox.Text.Trim();
            if (leveLBox.Text != "")
                level = leveLBox.Text.Trim();
            if(Front.Text.Trim()!="")
                 regex =  "/"+Front.Text.Trim();
            if(end.Text.Trim()!="")
                regex=end.Text.Trim()+"/";


            finddata.DataSource = FindQQsevice.Getfind(length, price, level,
                                                    connnumBox.Text.Trim(),
                                                    yearBox.Text,monthbox.Text,daybox.Text,songbao.Checked,regex,"1");
            //finddata.DataSource=FindQQsevice.Getfind(this.SearchText.Text.Trim());
            this.Text = "查找";
        }

        void FindQQsevice_findother(string progress)
        {
            this.Text = "当前已进行" + progress + "项";
        }

        void FindQQsevice_find(string progress)
        {
            this.Text = "当前已进行" + progress + "项";
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void finddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetDataObject(finddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            other.DataSource = null;
            other.DataSource = FindQQsevice.Getfindotherqq(FindQQsevice.qqdata((finddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString())));
        }

        private void myFind_Load(object sender, EventArgs e)
        {
            //string[] data = FindQQsevice.GetSetData();
            //lengthbox.DataSource = spkt.Getlist(data[0]); lengthbox.Text = "";
            //leveLBox.DataSource = spkt.Getlist(data[1]); leveLBox.Text = "";
            //priceBox.DataSource = spkt.Getlist(data[2]); priceBox.Text = "";
            //QageBox.DataSource = spkt.Getlist(data[3]); QageBox.Text = "";
            //connnumBox.DataSource = spkt.Getlist(data[4]); connnumBox.Text = "";
            //yearBox.DataSource = spkt.Getlist(data[5]); yearBox.Text = "";
            //monthbox.DataSource = spkt.Getlist(data[6]); monthbox.Text = "";
            //daybox.DataSource = spkt.Getlist(data[7]); daybox.Text = "";           
        }

        private void finddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void other_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetDataObject(finddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
        }
    }
}
