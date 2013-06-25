namespace GetQQ.form
{
    partial class DBconfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ip1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ip2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.ip3 = new System.Windows.Forms.NumericUpDown();
            this.ip4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dbname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dbuser = new System.Windows.Forms.TextBox();
            this.dbmima = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端    口：";
            // 
            // nud_port
            // 
            this.nud_port.Location = new System.Drawing.Point(89, 143);
            this.nud_port.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(93, 21);
            this.nud_port.TabIndex = 1;
            this.nud_port.Value = new decimal(new int[] {
            3306,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ip地址:";
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(69, 14);
            this.ip1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(45, 21);
            this.ip1.TabIndex = 3;
            this.ip1.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(137, 13);
            this.ip2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(45, 21);
            this.ip2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(256, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(205, 12);
            this.ip3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(45, 21);
            this.ip3.TabIndex = 7;
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(273, 12);
            this.ip4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(45, 21);
            this.ip4.TabIndex = 9;
            this.ip4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "数据库名称:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 12;
            this.label8.Text = "用 户 名:";
            // 
            // dbname
            // 
            this.dbname.Location = new System.Drawing.Point(89, 43);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(131, 21);
            this.dbname.TabIndex = 13;
            this.dbname.Text = "qqdb";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 14;
            this.label9.Text = "密    码:";
            // 
            // dbuser
            // 
            this.dbuser.Location = new System.Drawing.Point(89, 74);
            this.dbuser.Name = "dbuser";
            this.dbuser.Size = new System.Drawing.Size(131, 21);
            this.dbuser.TabIndex = 15;
            this.dbuser.Text = "root";
            // 
            // dbmima
            // 
            this.dbmima.Location = new System.Drawing.Point(89, 109);
            this.dbmima.Name = "dbmima";
            this.dbmima.Size = new System.Drawing.Size(131, 21);
            this.dbmima.TabIndex = 16;
            this.dbmima.Text = "saila";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 34);
            this.button1.TabIndex = 17;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DBconfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 186);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbmima);
            this.Controls.Add(this.dbuser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dbname);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ip4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ip3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ip2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_port);
            this.Controls.Add(this.label1);
            this.Name = "DBconfig";
            this.Text = "数据库链接配置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DBconfig_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ip2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown ip3;
        private System.Windows.Forms.NumericUpDown ip4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox dbname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox dbuser;
        private System.Windows.Forms.TextBox dbmima;
        private System.Windows.Forms.Button button1;
    }
}