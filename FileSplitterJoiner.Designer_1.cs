namespace FileSplitterJoiner
{
    partial class FileSplitterJoinner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSplitterJoinner));
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSplitter = new System.Windows.Forms.TabPage();
            this.btnSplitFile = new System.Windows.Forms.Button();
            this.btnSplitterDelete = new System.Windows.Forms.Button();
            this.btnSplitterAdd = new System.Windows.Forms.Button();
            this.txtSplitterRows = new System.Windows.Forms.TextBox();
            this.grvSplitter = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabJoinner = new System.Windows.Forms.TabPage();
            this.grvJoinner = new System.Windows.Forms.DataGridView();
            this.btnJoinFile = new System.Windows.Forms.Button();
            this.btnJoinnerDelete = new System.Windows.Forms.Button();
            this.btnJoinnerAdd = new System.Windows.Forms.Button();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.myStatus1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.myStatus2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.myStatusStrip = new System.Windows.Forms.StatusStrip();
            this.myToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.myProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.SplitterSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitterFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinnerSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinnerFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitter)).BeginInit();
            this.tabJoinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvJoinner)).BeginInit();
            this.myStatusStrip.SuspendLayout();
            this.myToolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.myToolStripContainer.ContentPanel.SuspendLayout();
            this.myToolStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.DefaultExt = "*.*";
            this.myOpenFileDialog.FileName = "*.*";
            this.myOpenFileDialog.Multiselect = true;
            this.myOpenFileDialog.SupportMultiDottedExtensions = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSplitter);
            this.tabControl1.Controls.Add(this.tabJoinner);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSplitter
            // 
            this.tabSplitter.Controls.Add(this.btnSplitFile);
            this.tabSplitter.Controls.Add(this.btnSplitterDelete);
            this.tabSplitter.Controls.Add(this.btnSplitterAdd);
            this.tabSplitter.Controls.Add(this.txtSplitterRows);
            this.tabSplitter.Controls.Add(this.grvSplitter);
            this.tabSplitter.Controls.Add(this.label3);
            this.tabSplitter.Location = new System.Drawing.Point(4, 22);
            this.tabSplitter.Name = "tabSplitter";
            this.tabSplitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabSplitter.Size = new System.Drawing.Size(532, 324);
            this.tabSplitter.TabIndex = 0;
            this.tabSplitter.Text = "Splitter";
            this.tabSplitter.UseVisualStyleBackColor = true;
            // 
            // btnSplitFile
            // 
            this.btnSplitFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitFile.Location = new System.Drawing.Point(435, 89);
            this.btnSplitFile.Name = "btnSplitFile";
            this.btnSplitFile.Size = new System.Drawing.Size(78, 47);
            this.btnSplitFile.TabIndex = 5;
            this.btnSplitFile.Text = "Tách File";
            this.btnSplitFile.UseVisualStyleBackColor = true;
            this.btnSplitFile.Click += new System.EventHandler(this.btnSplitFile_Click);
            // 
            // btnSplitterDelete
            // 
            this.btnSplitterDelete.Location = new System.Drawing.Point(435, 54);
            this.btnSplitterDelete.Name = "btnSplitterDelete";
            this.btnSplitterDelete.Size = new System.Drawing.Size(78, 24);
            this.btnSplitterDelete.TabIndex = 4;
            this.btnSplitterDelete.Text = "Xóa File";
            this.btnSplitterDelete.UseVisualStyleBackColor = true;
            this.btnSplitterDelete.Click += new System.EventHandler(this.btnSplitterDelete_Click);
            // 
            // btnSplitterAdd
            // 
            this.btnSplitterAdd.Location = new System.Drawing.Point(435, 18);
            this.btnSplitterAdd.Name = "btnSplitterAdd";
            this.btnSplitterAdd.Size = new System.Drawing.Size(78, 24);
            this.btnSplitterAdd.TabIndex = 2;
            this.btnSplitterAdd.Text = "Thêm File";
            this.btnSplitterAdd.UseVisualStyleBackColor = true;
            this.btnSplitterAdd.Click += new System.EventHandler(this.btnSplitterAdd_Click);
            // 
            // txtSplitterRows
            // 
            this.txtSplitterRows.Location = new System.Drawing.Point(145, 20);
            this.txtSplitterRows.Name = "txtSplitterRows";
            this.txtSplitterRows.Size = new System.Drawing.Size(269, 20);
            this.txtSplitterRows.TabIndex = 1;
            this.txtSplitterRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSplitterRows_KeyPress);
            // 
            // grvSplitter
            // 
            this.grvSplitter.AllowUserToAddRows = false;
            this.grvSplitter.AllowUserToResizeRows = false;
            this.grvSplitter.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvSplitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSplitter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SplitterSTT,
            this.SplitterFilePath});
            this.grvSplitter.Location = new System.Drawing.Point(16, 55);
            this.grvSplitter.MultiSelect = false;
            this.grvSplitter.Name = "grvSplitter";
            this.grvSplitter.ReadOnly = true;
            this.grvSplitter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvSplitter.RowTemplate.ReadOnly = true;
            this.grvSplitter.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSplitter.ShowEditingIcon = false;
            this.grvSplitter.Size = new System.Drawing.Size(398, 269);
            this.grvSplitter.TabIndex = 3;
            this.grvSplitter.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvSplitter_RowsRemoved);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập số dòng trong 1 file";
            // 
            // tabJoinner
            // 
            this.tabJoinner.Controls.Add(this.grvJoinner);
            this.tabJoinner.Controls.Add(this.btnJoinFile);
            this.tabJoinner.Controls.Add(this.btnJoinnerDelete);
            this.tabJoinner.Controls.Add(this.btnJoinnerAdd);
            this.tabJoinner.Location = new System.Drawing.Point(4, 22);
            this.tabJoinner.Name = "tabJoinner";
            this.tabJoinner.Padding = new System.Windows.Forms.Padding(3);
            this.tabJoinner.Size = new System.Drawing.Size(532, 324);
            this.tabJoinner.TabIndex = 1;
            this.tabJoinner.Text = "Joinner";
            this.tabJoinner.UseVisualStyleBackColor = true;
            // 
            // grvJoinner
            // 
            this.grvJoinner.AllowUserToAddRows = false;
            this.grvJoinner.AllowUserToResizeRows = false;
            this.grvJoinner.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvJoinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvJoinner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JoinnerSTT,
            this.JoinnerFilePath});
            this.grvJoinner.Location = new System.Drawing.Point(16, 19);
            this.grvJoinner.MultiSelect = false;
            this.grvJoinner.Name = "grvJoinner";
            this.grvJoinner.ReadOnly = true;
            this.grvJoinner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvJoinner.RowTemplate.ReadOnly = true;
            this.grvJoinner.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvJoinner.ShowEditingIcon = false;
            this.grvJoinner.Size = new System.Drawing.Size(398, 305);
            this.grvJoinner.TabIndex = 9;
            this.grvJoinner.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvJoinner_RowsRemoved);
            // 
            // btnJoinFile
            // 
            this.btnJoinFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinFile.Location = new System.Drawing.Point(435, 89);
            this.btnJoinFile.Name = "btnJoinFile";
            this.btnJoinFile.Size = new System.Drawing.Size(78, 47);
            this.btnJoinFile.TabIndex = 8;
            this.btnJoinFile.Text = "Ghép File";
            this.btnJoinFile.UseVisualStyleBackColor = true;
            this.btnJoinFile.Click += new System.EventHandler(this.btnJoinFile_Click);
            // 
            // btnJoinnerDelete
            // 
            this.btnJoinnerDelete.Location = new System.Drawing.Point(435, 54);
            this.btnJoinnerDelete.Name = "btnJoinnerDelete";
            this.btnJoinnerDelete.Size = new System.Drawing.Size(78, 24);
            this.btnJoinnerDelete.TabIndex = 6;
            this.btnJoinnerDelete.Text = "Xóa File";
            this.btnJoinnerDelete.UseVisualStyleBackColor = true;
            this.btnJoinnerDelete.Click += new System.EventHandler(this.btnJoinnerDelete_Click);
            // 
            // btnJoinnerAdd
            // 
            this.btnJoinnerAdd.Location = new System.Drawing.Point(435, 18);
            this.btnJoinnerAdd.Name = "btnJoinnerAdd";
            this.btnJoinnerAdd.Size = new System.Drawing.Size(78, 24);
            this.btnJoinnerAdd.TabIndex = 6;
            this.btnJoinnerAdd.Text = "Thêm File";
            this.btnJoinnerAdd.UseVisualStyleBackColor = true;
            this.btnJoinnerAdd.Click += new System.EventHandler(this.btnJoinnerAdd_Click);
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myBackgroundWorker_DoWork);
            this.myBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.myBackgroundWorker_ProgressChanged);
            this.myBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myBackgroundWorker_RunWorkerCompleted);
            // 
            // myStatus1
            // 
            this.myStatus1.BackColor = System.Drawing.Color.Fuchsia;
            this.myStatus1.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.myStatus1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.myStatus1.Name = "myStatus1";
            this.myStatus1.Size = new System.Drawing.Size(39, 17);
            this.myStatus1.Text = "Ready";
            // 
            // myStatus2
            // 
            this.myStatus2.BackColor = System.Drawing.Color.Blue;
            this.myStatus2.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.myStatus2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.myStatus2.Name = "myStatus2";
            this.myStatus2.Size = new System.Drawing.Size(80, 17);
            this.myStatus2.Text = "Đang tạo file: ";
            this.myStatus2.Visible = false;
            // 
            // myStatusStrip
            // 
            this.myStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.myStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatus1,
            this.myStatus2,
            this.myProgress});
            this.myStatusStrip.Location = new System.Drawing.Point(0, 0);
            this.myStatusStrip.Name = "myStatusStrip";
            this.myStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.myStatusStrip.Size = new System.Drawing.Size(540, 22);
            this.myStatusStrip.SizingGrip = false;
            this.myStatusStrip.TabIndex = 6;
            // 
            // myToolStripContainer
            // 
            // 
            // myToolStripContainer.BottomToolStripPanel
            // 
            this.myToolStripContainer.BottomToolStripPanel.Controls.Add(this.myStatusStrip);
            // 
            // myToolStripContainer.ContentPanel
            // 
            this.myToolStripContainer.ContentPanel.AutoScroll = true;
            this.myToolStripContainer.ContentPanel.Controls.Add(this.tabControl1);
            this.myToolStripContainer.ContentPanel.Size = new System.Drawing.Size(540, 350);
            this.myToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myToolStripContainer.LeftToolStripPanelVisible = false;
            this.myToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.myToolStripContainer.Name = "myToolStripContainer";
            this.myToolStripContainer.RightToolStripPanelVisible = false;
            this.myToolStripContainer.Size = new System.Drawing.Size(540, 372);
            this.myToolStripContainer.TabIndex = 1;
            this.myToolStripContainer.Text = "toolStripContainer1";
            this.myToolStripContainer.TopToolStripPanelVisible = false;
            // 
            // myProgress
            // 
            this.myProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.myProgress.Name = "myProgress";
            this.myProgress.Size = new System.Drawing.Size(100, 16);
            this.myProgress.Visible = false;
            // 
            // SplitterSTT
            // 
            this.SplitterSTT.HeaderText = "STT";
            this.SplitterSTT.Name = "SplitterSTT";
            this.SplitterSTT.ReadOnly = true;
            this.SplitterSTT.Width = 50;
            // 
            // SplitterFilePath
            // 
            this.SplitterFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SplitterFilePath.HeaderText = "Đường dẫn file";
            this.SplitterFilePath.Name = "SplitterFilePath";
            this.SplitterFilePath.ReadOnly = true;
            this.SplitterFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // JoinnerSTT
            // 
            this.JoinnerSTT.HeaderText = "STT";
            this.JoinnerSTT.Name = "JoinnerSTT";
            this.JoinnerSTT.ReadOnly = true;
            this.JoinnerSTT.Width = 50;
            // 
            // JoinnerFilePath
            // 
            this.JoinnerFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JoinnerFilePath.HeaderText = "Đường dẫn file";
            this.JoinnerFilePath.Name = "JoinnerFilePath";
            this.JoinnerFilePath.ReadOnly = true;
            this.JoinnerFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // FileSplitterJoinner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 372);
            this.Controls.Add(this.myToolStripContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FileSplitterJoinner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Splitter And Joinner";
            this.tabControl1.ResumeLayout(false);
            this.tabSplitter.ResumeLayout(false);
            this.tabSplitter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitter)).EndInit();
            this.tabJoinner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvJoinner)).EndInit();
            this.myStatusStrip.ResumeLayout(false);
            this.myStatusStrip.PerformLayout();
            this.myToolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.myToolStripContainer.BottomToolStripPanel.PerformLayout();
            this.myToolStripContainer.ContentPanel.ResumeLayout(false);
            this.myToolStripContainer.ResumeLayout(false);
            this.myToolStripContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSplitter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabJoinner;
        private System.Windows.Forms.TextBox txtSplitterRows;
        private System.Windows.Forms.Button btnJoinFile;
        private System.Windows.Forms.Button btnJoinnerAdd;
        private System.Windows.Forms.Button btnJoinnerDelete;
        private System.Windows.Forms.Button btnSplitFile;
        private System.Windows.Forms.Button btnSplitterDelete;
        private System.Windows.Forms.Button btnSplitterAdd;
        private System.Windows.Forms.DataGridView grvSplitter;
        private System.Windows.Forms.DataGridView grvJoinner;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.ToolStripStatusLabel myStatus1;
        private System.Windows.Forms.ToolStripStatusLabel myStatus2;
        private System.Windows.Forms.ToolStripContainer myToolStripContainer;
        private System.Windows.Forms.StatusStrip myStatusStrip;
        private System.Windows.Forms.ToolStripProgressBar myProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitterSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitterFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinnerSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinnerFilePath;
    }
}

