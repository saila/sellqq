namespace GetQQ
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_sName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_sellers = new System.Windows.Forms.DataGridView();
            this.tsid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ttypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsWwNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsQQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turlIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_tv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.manage = new System.Windows.Forms.ToolStripMenuItem();
            this.getData = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_typeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_show = new System.Windows.Forms.RichTextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtb_urls = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_sQQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sWW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellers)).BeginInit();
            this.cms_tv.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "网址管理";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(80, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "号码管理";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "设置界面";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(240, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "浏览框";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(320, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "咨询管理";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_sName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dgv_sellers);
            this.panel1.Controls.Add(this.txt_typeName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rtb_show);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.rtb_urls);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_sQQ);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_sPhone);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_sWW);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 511);
            this.panel1.TabIndex = 5;
            // 
            // txt_sName
            // 
            this.txt_sName.Location = new System.Drawing.Point(56, 9);
            this.txt_sName.Name = "txt_sName";
            this.txt_sName.Size = new System.Drawing.Size(120, 21);
            this.txt_sName.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "姓名";
            // 
            // dgv_sellers
            // 
            this.dgv_sellers.AllowUserToAddRows = false;
            this.dgv_sellers.AllowUserToDeleteRows = false;
            this.dgv_sellers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sellers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tsid,
            this.ttypeName,
            this.tsWwNum,
            this.tsName,
            this.tsPhone,
            this.tsQQ,
            this.turlIn});
            this.dgv_sellers.ContextMenuStrip = this.cms_tv;
            this.dgv_sellers.Location = new System.Drawing.Point(11, 131);
            this.dgv_sellers.MultiSelect = false;
            this.dgv_sellers.Name = "dgv_sellers";
            this.dgv_sellers.ReadOnly = true;
            this.dgv_sellers.RowTemplate.Height = 23;
            this.dgv_sellers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_sellers.Size = new System.Drawing.Size(567, 273);
            this.dgv_sellers.TabIndex = 14;
            // 
            // tsid
            // 
            this.tsid.DataPropertyName = "tsid";
            this.tsid.HeaderText = "序号";
            this.tsid.Name = "tsid";
            this.tsid.ReadOnly = true;
            // 
            // ttypeName
            // 
            this.ttypeName.DataPropertyName = "ttypeName";
            this.ttypeName.HeaderText = "分类名称";
            this.ttypeName.Name = "ttypeName";
            this.ttypeName.ReadOnly = true;
            // 
            // tsWwNum
            // 
            this.tsWwNum.DataPropertyName = "tsWwNum";
            this.tsWwNum.HeaderText = "旺旺号";
            this.tsWwNum.Name = "tsWwNum";
            this.tsWwNum.ReadOnly = true;
            // 
            // tsName
            // 
            this.tsName.DataPropertyName = "tsName";
            this.tsName.HeaderText = "姓名";
            this.tsName.Name = "tsName";
            this.tsName.ReadOnly = true;
            // 
            // tsPhone
            // 
            this.tsPhone.DataPropertyName = "tsPhone";
            this.tsPhone.HeaderText = "手机号";
            this.tsPhone.Name = "tsPhone";
            this.tsPhone.ReadOnly = true;
            // 
            // tsQQ
            // 
            this.tsQQ.DataPropertyName = "tsQQ";
            this.tsQQ.HeaderText = "QQ号";
            this.tsQQ.Name = "tsQQ";
            this.tsQQ.ReadOnly = true;
            // 
            // turlIn
            // 
            this.turlIn.DataPropertyName = "turlIn";
            this.turlIn.HeaderText = "入口网址";
            this.turlIn.Name = "turlIn";
            this.turlIn.ReadOnly = true;
            // 
            // cms_tv
            // 
            this.cms_tv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.manage,
            this.getData});
            this.cms_tv.Name = "cms_tv";
            this.cms_tv.Size = new System.Drawing.Size(143, 70);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(142, 22);
            this.edit.Text = "编辑";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // manage
            // 
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(142, 22);
            this.manage.Text = "管理二级目录";
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // getData
            // 
            this.getData.Name = "getData";
            this.getData.Size = new System.Drawing.Size(142, 22);
            this.getData.Text = "采集数据";
            // 
            // txt_typeName
            // 
            this.txt_typeName.Location = new System.Drawing.Point(251, 94);
            this.txt_typeName.Name = "txt_typeName";
            this.txt_typeName.Size = new System.Drawing.Size(221, 21);
            this.txt_typeName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "分类名称";
            // 
            // rtb_show
            // 
            this.rtb_show.Location = new System.Drawing.Point(14, 410);
            this.rtb_show.Name = "rtb_show";
            this.rtb_show.Size = new System.Drawing.Size(564, 96);
            this.rtb_show.TabIndex = 11;
            this.rtb_show.Text = "";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(495, 84);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 33);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "保存";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtb_urls
            // 
            this.rtb_urls.Location = new System.Drawing.Point(194, 24);
            this.rtb_urls.Name = "rtb_urls";
            this.rtb_urls.Size = new System.Drawing.Size(376, 56);
            this.rtb_urls.TabIndex = 9;
            this.rtb_urls.Text = "File:///F:/123\nhttp://h0029.taobao.com/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "网址列表";
            // 
            // txt_sQQ
            // 
            this.txt_sQQ.Location = new System.Drawing.Point(56, 64);
            this.txt_sQQ.Name = "txt_sQQ";
            this.txt_sQQ.Size = new System.Drawing.Size(120, 21);
            this.txt_sQQ.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "QQ号";
            // 
            // txt_sPhone
            // 
            this.txt_sPhone.Location = new System.Drawing.Point(56, 96);
            this.txt_sPhone.Name = "txt_sPhone";
            this.txt_sPhone.Size = new System.Drawing.Size(120, 21);
            this.txt_sPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "手机号";
            // 
            // txt_sWW
            // 
            this.txt_sWW.Location = new System.Drawing.Point(56, 37);
            this.txt_sWW.Name = "txt_sWW";
            this.txt_sWW.Size = new System.Drawing.Size(120, 21);
            this.txt_sWW.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旺旺号";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "数据采集软件";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sellers)).EndInit();
            this.cms_tv.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_sQQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sWW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_show;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox rtb_urls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_typeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_sellers;
        private System.Windows.Forms.ContextMenuStrip cms_tv;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem manage;
        private System.Windows.Forms.ToolStripMenuItem getData;
        private System.Windows.Forms.TextBox txt_sName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ttypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsWwNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsQQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn turlIn;
    }
}

