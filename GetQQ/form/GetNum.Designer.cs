namespace GetQQ.form
{
    partial class GetNum
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
            this.showNum = new System.Windows.Forms.DataGridView();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slid_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.srcRow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqLv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qqAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radio = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.isFreeProtect = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wwKehu = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.rtb_show = new System.Windows.Forms.RichTextBox();
            this.btn_saveNum = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showNum)).BeginInit();
            this.SuspendLayout();
            // 
            // showNum
            // 
            this.showNum.AllowUserToAddRows = false;
            this.showNum.AllowUserToDeleteRows = false;
            this.showNum.AllowUserToResizeRows = false;
            this.showNum.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showNum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showNum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cid,
            this.slid_c,
            this.srcRow,
            this.qqNum,
            this.price,
            this.qqLv,
            this.qqAge,
            this.qtid,
            this.radio,
            this.isFreeProtect,
            this.mima,
            this.wwKehu});
            this.showNum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.showNum.Location = new System.Drawing.Point(0, 0);
            this.showNum.Name = "showNum";
            this.showNum.RowTemplate.Height = 23;
            this.showNum.Size = new System.Drawing.Size(587, 429);
            this.showNum.TabIndex = 0;
            // 
            // cid
            // 
            this.cid.DataPropertyName = "cid";
            this.cid.HeaderText = "号码记录编号";
            this.cid.Name = "cid";
            this.cid.Visible = false;
            // 
            // slid_c
            // 
            this.slid_c.DataPropertyName = "slid";
            this.slid_c.HeaderText = "所属网页编号";
            this.slid_c.Name = "slid_c";
            this.slid_c.Visible = false;
            // 
            // srcRow
            // 
            this.srcRow.DataPropertyName = "srcRow";
            this.srcRow.HeaderText = "原行内容";
            this.srcRow.Name = "srcRow";
            this.srcRow.Visible = false;
            // 
            // qqNum
            // 
            this.qqNum.DataPropertyName = "qqNum";
            this.qqNum.HeaderText = "QQ号";
            this.qqNum.Name = "qqNum";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "价格";
            this.price.Name = "price";
            // 
            // qqLv
            // 
            this.qqLv.DataPropertyName = "qqLv";
            this.qqLv.HeaderText = "等级";
            this.qqLv.Name = "qqLv";
            this.qqLv.Visible = false;
            // 
            // qqAge
            // 
            this.qqAge.DataPropertyName = "qqAge";
            this.qqAge.HeaderText = "Q龄";
            this.qqAge.Name = "qqAge";
            this.qqAge.Visible = false;
            // 
            // qtid
            // 
            this.qtid.DataPropertyName = "qtid";
            this.qtid.HeaderText = "号码类型";
            this.qtid.Name = "qtid";
            // 
            // radio
            // 
            this.radio.DataPropertyName = "radio";
            this.radio.HeaderText = "交易状态";
            this.radio.Items.AddRange(new object[] {
            "未出售",
            "已出售"});
            this.radio.Name = "radio";
            // 
            // isFreeProtect
            // 
            this.isFreeProtect.DataPropertyName = "isFreeProtect";
            this.isFreeProtect.HeaderText = "是否送保";
            this.isFreeProtect.Name = "isFreeProtect";
            // 
            // mima
            // 
            this.mima.DataPropertyName = "mima";
            this.mima.HeaderText = "密码框";
            this.mima.Name = "mima";
            // 
            // wwKehu
            // 
            this.wwKehu.DataPropertyName = "wwKehu";
            this.wwKehu.HeaderText = "销售旺旺客服";
            this.wwKehu.Name = "wwKehu";
            // 
            // rtb_show
            // 
            this.rtb_show.Location = new System.Drawing.Point(0, 451);
            this.rtb_show.Name = "rtb_show";
            this.rtb_show.Size = new System.Drawing.Size(444, 103);
            this.rtb_show.TabIndex = 1;
            this.rtb_show.Text = "";
            // 
            // btn_saveNum
            // 
            this.btn_saveNum.Location = new System.Drawing.Point(460, 478);
            this.btn_saveNum.Name = "btn_saveNum";
            this.btn_saveNum.Size = new System.Drawing.Size(104, 39);
            this.btn_saveNum.TabIndex = 2;
            this.btn_saveNum.Text = "保存";
            this.btn_saveNum.UseVisualStyleBackColor = true;
            this.btn_saveNum.Click += new System.EventHandler(this.btn_saveNum_Click);
            // 
            // GetNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.btn_saveNum);
            this.Controls.Add(this.rtb_show);
            this.Controls.Add(this.showNum);
            this.Name = "GetNum";
            this.Text = "解析号码管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetNum_FormClosed);
            this.Load += new System.EventHandler(this.GetNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showNum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showNum;
        private System.Windows.Forms.RichTextBox rtb_show;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn slid_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn srcRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqLv;
        private System.Windows.Forms.DataGridViewTextBoxColumn qqAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtid;
        private System.Windows.Forms.DataGridViewComboBoxColumn radio;
        private System.Windows.Forms.DataGridViewTextBoxColumn isFreeProtect;
        private System.Windows.Forms.DataGridViewTextBoxColumn mima;
        private System.Windows.Forms.DataGridViewComboBoxColumn wwKehu;
        private System.Windows.Forms.Button btn_saveNum;
    }
}