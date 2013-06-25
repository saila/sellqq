using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GetQQ.Properties;

namespace GetQQ.form
{
    public partial class DBconfig : Form
    {
        public DBconfig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ip = ip1.Value + "." + ip2.Value + "." + ip3.Value + "." + ip4.Value;
            string qqdb = dbname.Text;
            string uName = dbuser.Text;
            string uPwd = dbmima.Text;
            decimal port = nud_port.Value;

            Settings s = Settings.Default;
            s.dbconn = "Database=" + qqdb + ";Data Source=" + ip + ";User Id=" + uName + ";Password=" + uPwd + ";pooling=false;CharSet=utf8;port=" + port + ";";
            s.Save();
            this.Close();
        }

        private void DBconfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            //new MainForm().ShowDialog();
           // new Set().ShowDialog();
            new myFind().ShowDialog();
        }


    }
}
