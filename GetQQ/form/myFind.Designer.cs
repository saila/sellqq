namespace GetQQ.form
{
    partial class myFind
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
            this.button1 = new System.Windows.Forms.Button();
            this.SearchText = new System.Windows.Forms.TextBox();
            this.finddata = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slid_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqLv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isFreeProtect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wwKehu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lengthbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.QageBox = new System.Windows.Forms.ComboBox();
            this.leveLBox = new System.Windows.Forms.ComboBox();
            this.connnumBox = new System.Windows.Forms.ComboBox();
            this.priceBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthbox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.daybox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.TextBox();
            this.Front = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.qqcheck = new System.Windows.Forms.CheckBox();
            this.Groupcheck = new System.Windows.Forms.CheckBox();
            this.groupconcheck = new System.Windows.Forms.CheckBox();
            this.qqconcheck = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.songbao = new System.Windows.Forms.CheckBox();
            this.other = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.finddata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.other)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "查找";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SearchText
            // 
            this.SearchText.Location = new System.Drawing.Point(12, 431);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(229, 21);
            this.SearchText.TabIndex = 1;
            // 
            // finddata
            // 
            this.finddata.AllowUserToAddRows = false;
            this.finddata.AllowUserToDeleteRows = false;
            this.finddata.AllowUserToResizeRows = false;
            this.finddata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.finddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.finddata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.slid_c,
            this.srcRow,
            this.qqNum,
            this.price,
            this.qqLv,
            this.qqAge,
            this.qtid,
            this.isFreeProtect,
            this.radio,
            this.level,
            this.wwKehu});
            this.finddata.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.finddata.Location = new System.Drawing.Point(-2, 12);
            this.finddata.Name = "finddata";
            this.finddata.ReadOnly = true;
            this.finddata.RowTemplate.Height = 23;
            this.finddata.Size = new System.Drawing.Size(615, 178);
            this.finddata.TabIndex = 2;
            this.finddata.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finddata_CellClick);
            this.finddata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.finddata_CellContentClick);
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "号码记录编号";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            this.cid.Visible = false;
            // 
            // slid_c
            // 
            this.slid_c.DataPropertyName = "slid";
            this.slid_c.HeaderText = "所属网页编号";
            this.slid_c.Name = "slid_c";
            this.slid_c.ReadOnly = true;
            this.slid_c.Visible = false;
            // 
            // srcRow
            // 
            this.srcRow.DataPropertyName = "srcRow";
            this.srcRow.HeaderText = "原行内容";
            this.srcRow.Name = "srcRow";
            this.srcRow.ReadOnly = true;
            this.srcRow.Visible = false;
            // 
            // qqNum
            // 
            this.qqNum.DataPropertyName = "qqNum";
            this.qqNum.HeaderText = "QQ号";
            this.qqNum.Name = "qqNum";
            this.qqNum.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // qqLv
            // 
            this.qqLv.DataPropertyName = "qqLv";
            this.qqLv.HeaderText = "等级";
            this.qqLv.Name = "qqLv";
            this.qqLv.ReadOnly = true;
            this.qqLv.Visible = false;
            // 
            // qqAge
            // 
            this.qqAge.DataPropertyName = "qqAge";
            this.qqAge.HeaderText = "Q龄";
            this.qqAge.Name = "qqAge";
            this.qqAge.ReadOnly = true;
            this.qqAge.Visible = false;
            // 
            // qtid
            // 
            this.qtid.DataPropertyName = "qtid";
            this.qtid.HeaderText = "号码类型";
            this.qtid.Name = "qtid";
            this.qtid.ReadOnly = true;
            // 
            // isFreeProtect
            // 
            this.isFreeProtect.DataPropertyName = "isFreeProtect";
            this.isFreeProtect.HeaderText = "是否送保";
            this.isFreeProtect.Name = "isFreeProtect";
            this.isFreeProtect.ReadOnly = true;
            // 
            // radio
            // 
            this.radio.DataPropertyName = "radio";
            this.radio.HeaderText = "交易状态";
            this.radio.Name = "radio";
            this.radio.ReadOnly = true;
            // 
            // level
            // 
            this.level.DataPropertyName = "level";
            this.level.HeaderText = "QQ等级";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // wwKehu
            // 
            this.wwKehu.DataPropertyName = "wwKehu";
            this.wwKehu.HeaderText = "旺旺客服";
            this.wwKehu.Name = "wwKehu";
            this.wwKehu.ReadOnly = true;
            // 
            // lengthbox
            // 
            this.lengthbox.FormattingEnabled = true;
            this.lengthbox.Location = new System.Drawing.Point(47, 533);
            this.lengthbox.Name = "lengthbox";
            this.lengthbox.Size = new System.Drawing.Size(61, 20);
            this.lengthbox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "类型";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 12);
            this.label8.TabIndex = 32;
            this.label8.Text = "月";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 31;
            this.label6.Text = "生日号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 536);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 30;
            this.label7.Text = "Q龄";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 29;
            this.label5.Text = "等级";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(459, 539);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 28;
            this.label10.Text = "连号数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 536);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 27;
            this.label4.Text = "价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 26;
            this.label3.Text = "长度";
            // 
            // yearBox
            // 
            this.yearBox.FormattingEnabled = true;
            this.yearBox.Location = new System.Drawing.Point(85, 566);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(61, 20);
            this.yearBox.TabIndex = 35;
            // 
            // QageBox
            // 
            this.QageBox.FormattingEnabled = true;
            this.QageBox.Location = new System.Drawing.Point(377, 536);
            this.QageBox.Name = "QageBox";
            this.QageBox.Size = new System.Drawing.Size(61, 20);
            this.QageBox.TabIndex = 36;
            // 
            // leveLBox
            // 
            this.leveLBox.FormattingEnabled = true;
            this.leveLBox.Location = new System.Drawing.Point(272, 533);
            this.leveLBox.Name = "leveLBox";
            this.leveLBox.Size = new System.Drawing.Size(61, 20);
            this.leveLBox.TabIndex = 37;
            // 
            // connnumBox
            // 
            this.connnumBox.FormattingEnabled = true;
            this.connnumBox.Location = new System.Drawing.Point(524, 536);
            this.connnumBox.Name = "connnumBox";
            this.connnumBox.Size = new System.Drawing.Size(61, 20);
            this.connnumBox.TabIndex = 38;
            this.connnumBox.Text = "1";
            // 
            // priceBox
            // 
            this.priceBox.FormattingEnabled = true;
            this.priceBox.Location = new System.Drawing.Point(149, 533);
            this.priceBox.Name = "priceBox";
            this.priceBox.Size = new System.Drawing.Size(61, 20);
            this.priceBox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "年";
            // 
            // monthbox
            // 
            this.monthbox.FormattingEnabled = true;
            this.monthbox.Location = new System.Drawing.Point(184, 566);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(61, 20);
            this.monthbox.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(264, 572);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 12);
            this.label11.TabIndex = 43;
            this.label11.Text = "日";
            // 
            // daybox
            // 
            this.daybox.FormattingEnabled = true;
            this.daybox.Location = new System.Drawing.Point(287, 568);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(61, 20);
            this.daybox.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(288, 434);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 48;
            this.label15.Text = "开头";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(348, 571);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 12);
            this.label16.TabIndex = 49;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(432, 431);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(56, 21);
            this.end.TabIndex = 52;
            // 
            // Front
            // 
            this.Front.Location = new System.Drawing.Point(323, 431);
            this.Front.Name = "Front";
            this.Front.Size = new System.Drawing.Size(56, 21);
            this.Front.TabIndex = 53;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(397, 434);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 55;
            this.label17.Text = "结尾";
            // 
            // qqcheck
            // 
            this.qqcheck.AutoSize = true;
            this.qqcheck.Checked = true;
            this.qqcheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.qqcheck.Location = new System.Drawing.Point(47, 495);
            this.qqcheck.Name = "qqcheck";
            this.qqcheck.Size = new System.Drawing.Size(48, 16);
            this.qqcheck.TabIndex = 57;
            this.qqcheck.Text = "QQ号";
            this.qqcheck.UseVisualStyleBackColor = true;
            // 
            // Groupcheck
            // 
            this.Groupcheck.AutoSize = true;
            this.Groupcheck.Location = new System.Drawing.Point(109, 495);
            this.Groupcheck.Name = "Groupcheck";
            this.Groupcheck.Size = new System.Drawing.Size(48, 16);
            this.Groupcheck.TabIndex = 58;
            this.Groupcheck.Text = "群号";
            this.Groupcheck.UseVisualStyleBackColor = true;
            // 
            // groupconcheck
            // 
            this.groupconcheck.AutoSize = true;
            this.groupconcheck.Location = new System.Drawing.Point(240, 496);
            this.groupconcheck.Name = "groupconcheck";
            this.groupconcheck.Size = new System.Drawing.Size(60, 16);
            this.groupconcheck.TabIndex = 60;
            this.groupconcheck.Text = "群连号";
            this.groupconcheck.UseVisualStyleBackColor = true;
            // 
            // qqconcheck
            // 
            this.qqconcheck.AutoSize = true;
            this.qqconcheck.Location = new System.Drawing.Point(171, 496);
            this.qqconcheck.Name = "qqconcheck";
            this.qqconcheck.Size = new System.Drawing.Size(60, 16);
            this.qqconcheck.TabIndex = 59;
            this.qqconcheck.Text = "QQ连号";
            this.qqconcheck.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(389, 12);
            this.label9.TabIndex = 63;
            this.label9.Text = "说明：开头和结尾用/，模糊数字用？号，指定长度的数字用等长度的*号";
            // 
            // songbao
            // 
            this.songbao.AutoSize = true;
            this.songbao.Location = new System.Drawing.Point(524, 578);
            this.songbao.Name = "songbao";
            this.songbao.Size = new System.Drawing.Size(48, 16);
            this.songbao.TabIndex = 65;
            this.songbao.Text = "送保";
            this.songbao.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AllowUserToAddRows = false;
            this.other.AllowUserToDeleteRows = false;
            this.other.AllowUserToResizeRows = false;
            this.other.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.other.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.other.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.other.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.other.Location = new System.Drawing.Point(5, 214);
            this.other.Name = "other";
            this.other.ReadOnly = true;
            this.other.RowTemplate.Height = 23;
            this.other.Size = new System.Drawing.Size(615, 178);
            this.other.TabIndex = 66;
            this.other.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.other_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cid";
            this.dataGridViewTextBoxColumn1.HeaderText = "号码记录编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "slid";
            this.dataGridViewTextBoxColumn2.HeaderText = "所属网页编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "srcRow";
            this.dataGridViewTextBoxColumn3.HeaderText = "原行内容";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "qqNum";
            this.dataGridViewTextBoxColumn4.HeaderText = "QQ号";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn5.HeaderText = "价格";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "qqLv";
            this.dataGridViewTextBoxColumn6.HeaderText = "等级";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "qqAge";
            this.dataGridViewTextBoxColumn7.HeaderText = "Q龄";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "qtid";
            this.dataGridViewTextBoxColumn8.HeaderText = "号码类型";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "isFreeProtect";
            this.dataGridViewTextBoxColumn9.HeaderText = "是否送保";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "radio";
            this.dataGridViewTextBoxColumn10.HeaderText = "交易状态";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "level";
            this.dataGridViewTextBoxColumn11.HeaderText = "QQ等级";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "wwKehu";
            this.dataGridViewTextBoxColumn12.HeaderText = "旺旺客服";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // myFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 606);
            this.Controls.Add(this.other);
            this.Controls.Add(this.songbao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupconcheck);
            this.Controls.Add(this.qqconcheck);
            this.Controls.Add(this.Groupcheck);
            this.Controls.Add(this.qqcheck);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Front);
            this.Controls.Add(this.end);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.monthbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceBox);
            this.Controls.Add(this.connnumBox);
            this.Controls.Add(this.leveLBox);
            this.Controls.Add(this.QageBox);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lengthbox);
            this.Controls.Add(this.finddata);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.button1);
            this.Name = "myFind";
            this.Text = "查找";
            this.Load += new System.EventHandler(this.myFind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.finddata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.other)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.DataGridView finddata;
        private System.Windows.Forms.ComboBox lengthbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox QageBox;
        private System.Windows.Forms.ComboBox leveLBox;
        private System.Windows.Forms.ComboBox connnumBox;
        private System.Windows.Forms.ComboBox priceBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox monthbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox daybox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox end;
        private System.Windows.Forms.TextBox Front;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox qqcheck;
        private System.Windows.Forms.CheckBox Groupcheck;
        private System.Windows.Forms.CheckBox groupconcheck;
        private System.Windows.Forms.CheckBox qqconcheck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox songbao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn slid_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn srcRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqLv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFreeProtect;
        private System.Windows.Forms.DataGridViewTextBoxColumn radio;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn wwKehu;
        private System.Windows.Forms.DataGridView other;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}