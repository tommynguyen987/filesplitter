namespace FileSplitterJoiner
{
    partial class frmShowEmail
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
            this.grvListEmails = new System.Windows.Forms.DataGridView();
            this.Operation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.btnUnCheckAll = new System.Windows.Forms.Button();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnReset = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.myStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.myCount = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.grvListEmails)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grvListEmails
            // 
            this.grvListEmails.AllowUserToAddRows = false;
            this.grvListEmails.AllowUserToDeleteRows = false;
            this.grvListEmails.AllowUserToResizeRows = false;
            this.grvListEmails.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvListEmails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvListEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvListEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Operation,
            this.STT,
            this.Email});
            this.grvListEmails.Location = new System.Drawing.Point(12, 13);
            this.grvListEmails.Name = "grvListEmails";
            this.grvListEmails.ReadOnly = true;
            this.grvListEmails.RowHeadersVisible = false;
            this.grvListEmails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvListEmails.RowTemplate.ReadOnly = true;
            this.grvListEmails.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvListEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvListEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvListEmails.ShowCellErrors = false;
            this.grvListEmails.ShowEditingIcon = false;
            this.grvListEmails.ShowRowErrors = false;
            this.grvListEmails.Size = new System.Drawing.Size(398, 285);
            this.grvListEmails.TabIndex = 18;
            this.grvListEmails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvListEmails_CellClick);
            this.grvListEmails.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvListEmails_RowsRemoved);
            // 
            // Operation
            // 
            this.Operation.FalseValue = "";
            this.Operation.HeaderText = "";
            this.Operation.Name = "Operation";
            this.Operation.ReadOnly = true;
            this.Operation.Width = 50;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.STT.Width = 50;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(423, 101);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 23);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Location = new System.Drawing.Point(423, 35);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(85, 23);
            this.btnCheckAll.TabIndex = 20;
            this.btnCheckAll.Text = "Check all";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // btnUnCheckAll
            // 
            this.btnUnCheckAll.Location = new System.Drawing.Point(423, 68);
            this.btnUnCheckAll.Name = "btnUnCheckAll";
            this.btnUnCheckAll.Size = new System.Drawing.Size(85, 23);
            this.btnUnCheckAll.TabIndex = 20;
            this.btnUnCheckAll.Text = "Uncheck all";
            this.btnUnCheckAll.UseVisualStyleBackColor = true;
            this.btnUnCheckAll.Click += new System.EventHandler(this.btnUnCheckAll_Click);
            // 
            // mySaveFileDialog
            // 
            this.mySaveFileDialog.DefaultExt = "txt";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(423, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 23);
            this.btnReset.TabIndex = 21;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatus,
            this.myCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 311);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(521, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // myStatus
            // 
            this.myStatus.Name = "myStatus";
            this.myStatus.Size = new System.Drawing.Size(39, 17);
            this.myStatus.Text = "Ready";
            // 
            // myCount
            // 
            this.myCount.Name = "myCount";
            this.myCount.Size = new System.Drawing.Size(38, 17);
            this.myCount.Text = "count";
            // 
            // frmShowEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 333);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUnCheckAll);
            this.Controls.Add(this.btnCheckAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grvListEmails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowEmail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List Emails";
            this.Load += new System.EventHandler(this.frmShowEmail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grvListEmails)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grvListEmails;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnUnCheckAll;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel myStatus;
        private System.Windows.Forms.ToolStripStatusLabel myCount;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Operation;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}