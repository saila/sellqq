namespace GetQQ
{
    partial class ManageUrl
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
            this.btn_allSave = new System.Windows.Forms.Button();
            this.btn_allSave_getData = new System.Windows.Forms.Button();
            this.btn_saveEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.cms_dgv_data.SuspendLayout();
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
            this.dgv_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellContentClick);
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
            this.delItem});
            this.cms_dgv_data.Name = "cms_dgv_data";
            this.cms_dgv_data.Size = new System.Drawing.Size(101, 26);
            // 
            // delItem
            // 
            this.delItem.Name = "delItem";
            this.delItem.Size = new System.Drawing.Size(100, 22);
            this.delItem.Text = "删除";
            this.delItem.Click += new System.EventHandler(this.delItem_Click);
            // 
            // btn_allSave
            // 
            this.btn_allSave.Enabled = false;
            this.btn_allSave.Location = new System.Drawing.Point(261, 526);
            this.btn_allSave.Name = "btn_allSave";
            this.btn_allSave.Size = new System.Drawing.Size(172, 36);
            this.btn_allSave.TabIndex = 3;
            this.btn_allSave.Text = "检测更新(只更新距离上次采集7天以上的记录)";
            this.btn_allSave.UseVisualStyleBackColor = true;
            this.btn_allSave.Click += new System.EventHandler(this.btn_allSave_Click);
            // 
            // btn_allSave_getData
            // 
            this.btn_allSave_getData.Enabled = false;
            this.btn_allSave_getData.Location = new System.Drawing.Point(455, 526);
            this.btn_allSave_getData.Name = "btn_allSave_getData";
            this.btn_allSave_getData.Size = new System.Drawing.Size(114, 36);
            this.btn_allSave_getData.TabIndex = 4;
            this.btn_allSave_getData.Text = "全部更新数据(所有数据全部更新)";
            this.btn_allSave_getData.UseVisualStyleBackColor = true;
            this.btn_allSave_getData.Click += new System.EventHandler(this.btn_allSave_getData_Click);
            // 
            // btn_saveEdit
            // 
            this.btn_saveEdit.Enabled = false;
            this.btn_saveEdit.Location = new System.Drawing.Point(159, 526);
            this.btn_saveEdit.Name = "btn_saveEdit";
            this.btn_saveEdit.Size = new System.Drawing.Size(96, 36);
            this.btn_saveEdit.TabIndex = 5;
            this.btn_saveEdit.Text = "保存更改";
            this.btn_saveEdit.UseVisualStyleBackColor = true;
            this.btn_saveEdit.Click += new System.EventHandler(this.btn_saveEdit_Click);
            // 
            // ManageUrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.ContextMenuStrip = this.cms_dgv_data;
            this.Controls.Add(this.btn_saveEdit);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.btn_allSave);
            this.Controls.Add(this.btn_allSave_getData);
            this.Name = "ManageUrl";
            this.Text = "二级目录管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetUrl_FormClosed);
            this.Load += new System.EventHandler(this.GetUrl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.cms_dgv_data.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.ContextMenuStrip cms_dgv_data;
        private System.Windows.Forms.ToolStripMenuItem delItem;
        private System.Windows.Forms.Button btn_allSave;
        private System.Windows.Forms.Button btn_allSave_getData;
        private System.Windows.Forms.DataGridViewTextBoxColumn slid;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleNote;
        private System.Windows.Forms.DataGridViewLinkColumn url;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.Button btn_saveEdit;
    }
}