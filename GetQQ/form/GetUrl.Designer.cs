namespace GetQQ
{
    partial class GetUrl
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
            this.components = new System.ComponentModel.Container();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.slid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_dgv_data = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getDataByThis = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_allSave = new System.Windows.Forms.Button();
            this.btn_allSave_getData = new System.Windows.Forms.Button();
            this.nud_before = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_after = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.cms_dgv_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_before)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_after)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_data
            // 
            this.dgv_data.AllowUserToAddRows = false;
            this.dgv_data.AllowUserToDeleteRows = false;
            this.dgv_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slid,
            this.title,
            this.titleNote,
            this.url,
            this.state});
            this.dgv_data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgv_data.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgv_data.Location = new System.Drawing.Point(12, 12);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowTemplate.Height = 23;
            this.dgv_data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_data.Size = new System.Drawing.Size(568, 508);
            this.dgv_data.TabIndex = 0;
            // 
            // slid
            // 
            this.slid.DataPropertyName = "slid";
            this.slid.HeaderText = "编号";
            this.slid.Name = "slid";
            this.slid.ReadOnly = true;
            this.slid.Visible = false;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "标题";
            this.title.Name = "title";
            // 
            // titleNote
            // 
            this.titleNote.DataPropertyName = "titleNote";
            this.titleNote.HeaderText = "标题备注";
            this.titleNote.Name = "titleNote";
            this.titleNote.ReadOnly = true;
            // 
            // url
            // 
            this.url.DataPropertyName = "url";
            this.url.HeaderText = "网址";
            this.url.Name = "url";
            this.url.ReadOnly = true;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            // 
            // cms_dgv_data
            // 
            this.cms_dgv_data.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delItem,
            this.getDataByThis});
            this.cms_dgv_data.Name = "cms_dgv_data";
            this.cms_dgv_data.Size = new System.Drawing.Size(153, 70);
            this.cms_dgv_data.Opening += new System.ComponentModel.CancelEventHandler(this.cms_dgv_data_Opening);
            // 
            // delItem
            // 
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(152, 22);
            this.delItem.Text = "删除";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // getDataByThis
            // 
            this.getDataByThis.Name = "getDataByThis";
            this.getDataByThis.Size = new System.Drawing.Size(152, 22);
            this.getDataByThis.Text = "采集数据";
            this.getDataByThis.Click += new System.EventHandler(this.getDataByThis_Click);
            // 
            // btn_allSave
            // 
            this.btn_allSave.Location = new System.Drawing.Point(372, 526);
            this.btn_allSave.Name = "btn_allSave";
            this.btn_allSave.Size = new System.Drawing.Size(85, 36);
            this.btn_allSave.TabIndex = 3;
            this.btn_allSave.Text = "全部保存";
            this.btn_allSave.UseVisualStyleBackColor = true;
            this.btn_allSave.Click += new System.EventHandler(this.btn_allSave_Click);
            // 
            // btn_allSave_getData
            // 
            this.btn_allSave_getData.Enabled = false;
            this.btn_allSave_getData.Location = new System.Drawing.Point(463, 526);
            this.btn_allSave_getData.Name = "btn_allSave_getData";
            this.btn_allSave_getData.Size = new System.Drawing.Size(114, 36);
            this.btn_allSave_getData.TabIndex = 4;
            this.btn_allSave_getData.Text = "全部采集数据";
            this.btn_allSave_getData.UseVisualStyleBackColor = true;
            this.btn_allSave_getData.Click += new System.EventHandler(this.btn_allSave_getData_Click);
            // 
            // nud_before
            // 
            this.nud_before.Location = new System.Drawing.Point(99, 533);
            this.nud_before.Name = "nud_before";
            this.nud_before.Size = new System.Drawing.Size(78, 21);
            this.nud_before.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "前面删除行数";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "后面删除行数";
            // 
            // nud_after
            // 
            this.nud_after.Location = new System.Drawing.Point(266, 533);
            this.nud_after.Name = "nud_after";
            this.nud_after.Size = new System.Drawing.Size(78, 21);
            this.nud_after.TabIndex = 7;
            // 
            // GetUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.ContextMenuStrip = this.cms_dgv_data;
            this.Controls.Add(this.nud_after);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_before);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_allSave_getData);
            this.Controls.Add(this.btn_allSave);
            this.Name = "GetUrl";
            this.Text = "二级目录管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetUrl_FormClosed);
            this.Load += new System.EventHandler(this.GetUrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.cms_dgv_data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_before)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_after)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.ContextMenuStrip cms_dgv_data;
        private System.Windows.Forms.ToolStripMenuItem delItem;
        private System.Windows.Forms.Button btn_allSave;
        private System.Windows.Forms.Button btn_allSave_getData;
        private System.Windows.Forms.NumericUpDown nud_before;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_after;
        private System.Windows.Forms.ToolStripMenuItem getDataByThis;
        private System.Windows.Forms.DataGridViewTextBoxColumn slid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNote;
        private System.Windows.Forms.DataGridViewLinkColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}