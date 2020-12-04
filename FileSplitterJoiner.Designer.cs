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
            this.chkSplitterDeleted = new System.Windows.Forms.CheckBox();
            this.btnSplitFile = new System.Windows.Forms.Button();
            this.btnSplitterDelete = new System.Windows.Forms.Button();
            this.btnSplitterAdd = new System.Windows.Forms.Button();
            this.txtSplitterRows = new System.Windows.Forms.TextBox();
            this.grvSplitter = new System.Windows.Forms.DataGridView();
            this.SplitterSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitterFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitterCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.tabJoinner = new System.Windows.Forms.TabPage();
            this.chkJoinnerDeleted = new System.Windows.Forms.CheckBox();
            this.grvJoinner = new System.Windows.Forms.DataGridView();
            this.JoinnerSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinnerFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoinnerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnJoinFile = new System.Windows.Forms.Button();
            this.btnJoinnerDelete = new System.Windows.Forms.Button();
            this.btnJoinnerAdd = new System.Windows.Forms.Button();
            this.tabCheck = new System.Windows.Forms.TabPage();
            this.rdPhone = new System.Windows.Forms.RadioButton();
            this.rdEmail = new System.Windows.Forms.RadioButton();
            this.grvCheck = new System.Windows.Forms.DataGridView();
            this.CheckSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheckFile = new System.Windows.Forms.Button();
            this.btnCheckDelete = new System.Windows.Forms.Button();
            this.btnCheckAdd = new System.Windows.Forms.Button();
            this.tabSplitEmailByGender = new System.Windows.Forms.TabPage();
            this.chkSplitterGenderDeleted = new System.Windows.Forms.CheckBox();
            this.grvSplitEmail = new System.Windows.Forms.DataGridView();
            this.SplitEmailSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitEmailFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SplitEmailCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowEmail = new System.Windows.Forms.Button();
            this.btnSplitEmail = new System.Windows.Forms.Button();
            this.btnSplitEmailDelete = new System.Windows.Forms.Button();
            this.btnSplitEmailAdd = new System.Windows.Forms.Button();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.myStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.myStatusStrip = new System.Windows.Forms.StatusStrip();
            this.myToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.rdProxy = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabSplitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitter)).BeginInit();
            this.tabJoinner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvJoinner)).BeginInit();
            this.tabCheck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCheck)).BeginInit();
            this.tabSplitEmailByGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitEmail)).BeginInit();
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
            this.myOpenFileDialog.Filter = "Text Files (.txt)|*.txt";
            this.myOpenFileDialog.Multiselect = true;
            this.myOpenFileDialog.SupportMultiDottedExtensions = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSplitter);
            this.tabControl1.Controls.Add(this.tabJoinner);
            this.tabControl1.Controls.Add(this.tabCheck);
            this.tabControl1.Controls.Add(this.tabSplitEmailByGender);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSplitter
            // 
            this.tabSplitter.Controls.Add(this.chkSplitterDeleted);
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
            // chkSplitterDeleted
            // 
            this.chkSplitterDeleted.AutoSize = true;
            this.chkSplitterDeleted.Location = new System.Drawing.Point(444, 132);
            this.chkSplitterDeleted.Name = "chkSplitterDeleted";
            this.chkSplitterDeleted.Size = new System.Drawing.Size(57, 17);
            this.chkSplitterDeleted.TabIndex = 6;
            this.chkSplitterDeleted.Text = "Delete";
            this.chkSplitterDeleted.UseVisualStyleBackColor = true;
            // 
            // btnSplitFile
            // 
            this.btnSplitFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitFile.Location = new System.Drawing.Point(443, 80);
            this.btnSplitFile.Name = "btnSplitFile";
            this.btnSplitFile.Size = new System.Drawing.Size(78, 47);
            this.btnSplitFile.TabIndex = 5;
            this.btnSplitFile.Text = "Tách File";
            this.btnSplitFile.UseVisualStyleBackColor = true;
            this.btnSplitFile.Click += new System.EventHandler(this.btnSplitFile_Click);
            // 
            // btnSplitterDelete
            // 
            this.btnSplitterDelete.Location = new System.Drawing.Point(443, 45);
            this.btnSplitterDelete.Name = "btnSplitterDelete";
            this.btnSplitterDelete.Size = new System.Drawing.Size(78, 24);
            this.btnSplitterDelete.TabIndex = 4;
            this.btnSplitterDelete.Text = "Xóa File";
            this.btnSplitterDelete.UseVisualStyleBackColor = true;
            this.btnSplitterDelete.Click += new System.EventHandler(this.btnSplitterDelete_Click);
            // 
            // btnSplitterAdd
            // 
            this.btnSplitterAdd.Location = new System.Drawing.Point(443, 9);
            this.btnSplitterAdd.Name = "btnSplitterAdd";
            this.btnSplitterAdd.Size = new System.Drawing.Size(78, 24);
            this.btnSplitterAdd.TabIndex = 2;
            this.btnSplitterAdd.Text = "Thêm File";
            this.btnSplitterAdd.UseVisualStyleBackColor = true;
            this.btnSplitterAdd.Click += new System.EventHandler(this.btnSplitterAdd_Click);
            // 
            // txtSplitterRows
            // 
            this.txtSplitterRows.Location = new System.Drawing.Point(139, 11);
            this.txtSplitterRows.Name = "txtSplitterRows";
            this.txtSplitterRows.Size = new System.Drawing.Size(291, 20);
            this.txtSplitterRows.TabIndex = 1;
            this.txtSplitterRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSplitterRows_KeyPress);
            // 
            // grvSplitter
            // 
            this.grvSplitter.AllowUserToAddRows = false;
            this.grvSplitter.AllowUserToDeleteRows = false;
            this.grvSplitter.AllowUserToResizeRows = false;
            this.grvSplitter.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvSplitter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvSplitter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSplitter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SplitterSTT,
            this.SplitterFilePath,
            this.SplitterCount});
            this.grvSplitter.Location = new System.Drawing.Point(10, 46);
            this.grvSplitter.MultiSelect = false;
            this.grvSplitter.Name = "grvSplitter";
            this.grvSplitter.ReadOnly = true;
            this.grvSplitter.RowHeadersVisible = false;
            this.grvSplitter.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvSplitter.RowTemplate.ReadOnly = true;
            this.grvSplitter.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSplitter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvSplitter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvSplitter.ShowCellErrors = false;
            this.grvSplitter.ShowEditingIcon = false;
            this.grvSplitter.ShowRowErrors = false;
            this.grvSplitter.Size = new System.Drawing.Size(420, 269);
            this.grvSplitter.TabIndex = 3;
            this.grvSplitter.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvSplitter_RowsRemoved);
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
            // SplitterCount
            // 
            this.SplitterCount.HeaderText = "Số lượng";
            this.SplitterCount.Name = "SplitterCount";
            this.SplitterCount.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập số dòng trong 1 file";
            // 
            // tabJoinner
            // 
            this.tabJoinner.Controls.Add(this.chkJoinnerDeleted);
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
            // chkJoinnerDeleted
            // 
            this.chkJoinnerDeleted.AutoSize = true;
            this.chkJoinnerDeleted.Location = new System.Drawing.Point(444, 132);
            this.chkJoinnerDeleted.Name = "chkJoinnerDeleted";
            this.chkJoinnerDeleted.Size = new System.Drawing.Size(57, 17);
            this.chkJoinnerDeleted.TabIndex = 10;
            this.chkJoinnerDeleted.Text = "Delete";
            this.chkJoinnerDeleted.UseVisualStyleBackColor = true;
            // 
            // grvJoinner
            // 
            this.grvJoinner.AllowUserToAddRows = false;
            this.grvJoinner.AllowUserToDeleteRows = false;
            this.grvJoinner.AllowUserToResizeRows = false;
            this.grvJoinner.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvJoinner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvJoinner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvJoinner.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JoinnerSTT,
            this.JoinnerFilePath,
            this.JoinnerCount});
            this.grvJoinner.Location = new System.Drawing.Point(10, 9);
            this.grvJoinner.MultiSelect = false;
            this.grvJoinner.Name = "grvJoinner";
            this.grvJoinner.ReadOnly = true;
            this.grvJoinner.RowHeadersVisible = false;
            this.grvJoinner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvJoinner.RowTemplate.ReadOnly = true;
            this.grvJoinner.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvJoinner.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvJoinner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvJoinner.ShowCellErrors = false;
            this.grvJoinner.ShowEditingIcon = false;
            this.grvJoinner.ShowRowErrors = false;
            this.grvJoinner.Size = new System.Drawing.Size(420, 307);
            this.grvJoinner.TabIndex = 9;
            this.grvJoinner.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvJoinner_RowsRemoved);
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
            // JoinnerCount
            // 
            this.JoinnerCount.HeaderText = "Số lượng";
            this.JoinnerCount.Name = "JoinnerCount";
            this.JoinnerCount.ReadOnly = true;
            // 
            // btnJoinFile
            // 
            this.btnJoinFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoinFile.Location = new System.Drawing.Point(443, 80);
            this.btnJoinFile.Name = "btnJoinFile";
            this.btnJoinFile.Size = new System.Drawing.Size(78, 47);
            this.btnJoinFile.TabIndex = 8;
            this.btnJoinFile.Text = "Ghép File";
            this.btnJoinFile.UseVisualStyleBackColor = true;
            this.btnJoinFile.Click += new System.EventHandler(this.btnJoinFile_Click);
            // 
            // btnJoinnerDelete
            // 
            this.btnJoinnerDelete.Location = new System.Drawing.Point(443, 45);
            this.btnJoinnerDelete.Name = "btnJoinnerDelete";
            this.btnJoinnerDelete.Size = new System.Drawing.Size(78, 24);
            this.btnJoinnerDelete.TabIndex = 6;
            this.btnJoinnerDelete.Text = "Xóa File";
            this.btnJoinnerDelete.UseVisualStyleBackColor = true;
            this.btnJoinnerDelete.Click += new System.EventHandler(this.btnJoinnerDelete_Click);
            // 
            // btnJoinnerAdd
            // 
            this.btnJoinnerAdd.Location = new System.Drawing.Point(443, 9);
            this.btnJoinnerAdd.Name = "btnJoinnerAdd";
            this.btnJoinnerAdd.Size = new System.Drawing.Size(78, 24);
            this.btnJoinnerAdd.TabIndex = 6;
            this.btnJoinnerAdd.Text = "Thêm File";
            this.btnJoinnerAdd.UseVisualStyleBackColor = true;
            this.btnJoinnerAdd.Click += new System.EventHandler(this.btnJoinnerAdd_Click);
            // 
            // tabCheck
            // 
            this.tabCheck.Controls.Add(this.rdProxy);
            this.tabCheck.Controls.Add(this.rdPhone);
            this.tabCheck.Controls.Add(this.rdEmail);
            this.tabCheck.Controls.Add(this.grvCheck);
            this.tabCheck.Controls.Add(this.btnCheckFile);
            this.tabCheck.Controls.Add(this.btnCheckDelete);
            this.tabCheck.Controls.Add(this.btnCheckAdd);
            this.tabCheck.Location = new System.Drawing.Point(4, 22);
            this.tabCheck.Name = "tabCheck";
            this.tabCheck.Padding = new System.Windows.Forms.Padding(3);
            this.tabCheck.Size = new System.Drawing.Size(532, 324);
            this.tabCheck.TabIndex = 2;
            this.tabCheck.Text = "Check";
            this.tabCheck.UseVisualStyleBackColor = true;
            // 
            // rdPhone
            // 
            this.rdPhone.AutoSize = true;
            this.rdPhone.Location = new System.Drawing.Point(444, 158);
            this.rdPhone.Name = "rdPhone";
            this.rdPhone.Size = new System.Drawing.Size(56, 17);
            this.rdPhone.TabIndex = 14;
            this.rdPhone.Text = "Phone";
            this.rdPhone.UseVisualStyleBackColor = true;
            // 
            // rdEmail
            // 
            this.rdEmail.AutoSize = true;
            this.rdEmail.Checked = true;
            this.rdEmail.Location = new System.Drawing.Point(444, 136);
            this.rdEmail.Name = "rdEmail";
            this.rdEmail.Size = new System.Drawing.Size(50, 17);
            this.rdEmail.TabIndex = 14;
            this.rdEmail.TabStop = true;
            this.rdEmail.Text = "Email";
            this.rdEmail.UseVisualStyleBackColor = true;
            // 
            // grvCheck
            // 
            this.grvCheck.AllowUserToAddRows = false;
            this.grvCheck.AllowUserToDeleteRows = false;
            this.grvCheck.AllowUserToResizeRows = false;
            this.grvCheck.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvCheck.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvCheck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCheck.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckSTT,
            this.CheckFilePath,
            this.CheckCount});
            this.grvCheck.Location = new System.Drawing.Point(10, 10);
            this.grvCheck.MultiSelect = false;
            this.grvCheck.Name = "grvCheck";
            this.grvCheck.ReadOnly = true;
            this.grvCheck.RowHeadersVisible = false;
            this.grvCheck.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvCheck.RowTemplate.ReadOnly = true;
            this.grvCheck.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvCheck.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvCheck.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvCheck.ShowCellErrors = false;
            this.grvCheck.ShowEditingIcon = false;
            this.grvCheck.ShowRowErrors = false;
            this.grvCheck.Size = new System.Drawing.Size(420, 305);
            this.grvCheck.TabIndex = 13;
            this.grvCheck.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvCheck_RowsRemoved);
            // 
            // CheckSTT
            // 
            this.CheckSTT.HeaderText = "STT";
            this.CheckSTT.Name = "CheckSTT";
            this.CheckSTT.ReadOnly = true;
            this.CheckSTT.Width = 50;
            // 
            // CheckFilePath
            // 
            this.CheckFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckFilePath.HeaderText = "Đường dẫn file";
            this.CheckFilePath.Name = "CheckFilePath";
            this.CheckFilePath.ReadOnly = true;
            this.CheckFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // CheckCount
            // 
            this.CheckCount.HeaderText = "Số lượng";
            this.CheckCount.Name = "CheckCount";
            this.CheckCount.ReadOnly = true;
            // 
            // btnCheckFile
            // 
            this.btnCheckFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckFile.Location = new System.Drawing.Point(443, 80);
            this.btnCheckFile.Name = "btnCheckFile";
            this.btnCheckFile.Size = new System.Drawing.Size(78, 47);
            this.btnCheckFile.TabIndex = 12;
            this.btnCheckFile.Text = "Kiểm Tra File";
            this.btnCheckFile.UseVisualStyleBackColor = true;
            this.btnCheckFile.Click += new System.EventHandler(this.btnCheckFile_Click);
            // 
            // btnCheckDelete
            // 
            this.btnCheckDelete.Location = new System.Drawing.Point(443, 45);
            this.btnCheckDelete.Name = "btnCheckDelete";
            this.btnCheckDelete.Size = new System.Drawing.Size(78, 24);
            this.btnCheckDelete.TabIndex = 10;
            this.btnCheckDelete.Text = "Xóa File";
            this.btnCheckDelete.UseVisualStyleBackColor = true;
            this.btnCheckDelete.Click += new System.EventHandler(this.btnCheckDelete_Click);
            // 
            // btnCheckAdd
            // 
            this.btnCheckAdd.Location = new System.Drawing.Point(443, 9);
            this.btnCheckAdd.Name = "btnCheckAdd";
            this.btnCheckAdd.Size = new System.Drawing.Size(78, 24);
            this.btnCheckAdd.TabIndex = 11;
            this.btnCheckAdd.Text = "Thêm File";
            this.btnCheckAdd.UseVisualStyleBackColor = true;
            this.btnCheckAdd.Click += new System.EventHandler(this.btnCheckAdd_Click);
            // 
            // tabSplitEmailByGender
            // 
            this.tabSplitEmailByGender.Controls.Add(this.chkSplitterGenderDeleted);
            this.tabSplitEmailByGender.Controls.Add(this.grvSplitEmail);
            this.tabSplitEmailByGender.Controls.Add(this.btnShowEmail);
            this.tabSplitEmailByGender.Controls.Add(this.btnSplitEmail);
            this.tabSplitEmailByGender.Controls.Add(this.btnSplitEmailDelete);
            this.tabSplitEmailByGender.Controls.Add(this.btnSplitEmailAdd);
            this.tabSplitEmailByGender.Location = new System.Drawing.Point(4, 22);
            this.tabSplitEmailByGender.Name = "tabSplitEmailByGender";
            this.tabSplitEmailByGender.Padding = new System.Windows.Forms.Padding(3);
            this.tabSplitEmailByGender.Size = new System.Drawing.Size(532, 324);
            this.tabSplitEmailByGender.TabIndex = 3;
            this.tabSplitEmailByGender.Text = "Split By Gender";
            this.tabSplitEmailByGender.UseVisualStyleBackColor = true;
            // 
            // chkSplitterGenderDeleted
            // 
            this.chkSplitterGenderDeleted.AutoSize = true;
            this.chkSplitterGenderDeleted.Location = new System.Drawing.Point(444, 189);
            this.chkSplitterGenderDeleted.Name = "chkSplitterGenderDeleted";
            this.chkSplitterGenderDeleted.Size = new System.Drawing.Size(57, 17);
            this.chkSplitterGenderDeleted.TabIndex = 18;
            this.chkSplitterGenderDeleted.Text = "Delete";
            this.chkSplitterGenderDeleted.UseVisualStyleBackColor = true;
            // 
            // grvSplitEmail
            // 
            this.grvSplitEmail.AllowUserToAddRows = false;
            this.grvSplitEmail.AllowUserToDeleteRows = false;
            this.grvSplitEmail.AllowUserToResizeRows = false;
            this.grvSplitEmail.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.grvSplitEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.grvSplitEmail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvSplitEmail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SplitEmailSTT,
            this.SplitEmailFilePath,
            this.SplitEmailCount});
            this.grvSplitEmail.Location = new System.Drawing.Point(10, 10);
            this.grvSplitEmail.MultiSelect = false;
            this.grvSplitEmail.Name = "grvSplitEmail";
            this.grvSplitEmail.ReadOnly = true;
            this.grvSplitEmail.RowHeadersVisible = false;
            this.grvSplitEmail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grvSplitEmail.RowTemplate.ReadOnly = true;
            this.grvSplitEmail.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grvSplitEmail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grvSplitEmail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grvSplitEmail.ShowCellErrors = false;
            this.grvSplitEmail.ShowEditingIcon = false;
            this.grvSplitEmail.ShowRowErrors = false;
            this.grvSplitEmail.Size = new System.Drawing.Size(420, 305);
            this.grvSplitEmail.TabIndex = 17;
            this.grvSplitEmail.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.grvSplitEmail_RowsRemoved);
            // 
            // SplitEmailSTT
            // 
            this.SplitEmailSTT.HeaderText = "STT";
            this.SplitEmailSTT.Name = "SplitEmailSTT";
            this.SplitEmailSTT.ReadOnly = true;
            this.SplitEmailSTT.Width = 50;
            // 
            // SplitEmailFilePath
            // 
            this.SplitEmailFilePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SplitEmailFilePath.HeaderText = "Đường dẫn file";
            this.SplitEmailFilePath.Name = "SplitEmailFilePath";
            this.SplitEmailFilePath.ReadOnly = true;
            this.SplitEmailFilePath.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // SplitEmailCount
            // 
            this.SplitEmailCount.HeaderText = "Số lượng";
            this.SplitEmailCount.Name = "SplitEmailCount";
            this.SplitEmailCount.ReadOnly = true;
            // 
            // btnShowEmail
            // 
            this.btnShowEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmail.Location = new System.Drawing.Point(443, 79);
            this.btnShowEmail.Name = "btnShowEmail";
            this.btnShowEmail.Size = new System.Drawing.Size(78, 47);
            this.btnShowEmail.TabIndex = 16;
            this.btnShowEmail.Text = "Hiển Thị Emails";
            this.btnShowEmail.UseVisualStyleBackColor = true;
            this.btnShowEmail.Click += new System.EventHandler(this.btnShowEmail_Click);
            // 
            // btnSplitEmail
            // 
            this.btnSplitEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplitEmail.Location = new System.Drawing.Point(443, 137);
            this.btnSplitEmail.Name = "btnSplitEmail";
            this.btnSplitEmail.Size = new System.Drawing.Size(78, 47);
            this.btnSplitEmail.TabIndex = 16;
            this.btnSplitEmail.Text = "Tách Email";
            this.btnSplitEmail.UseVisualStyleBackColor = true;
            this.btnSplitEmail.Click += new System.EventHandler(this.btnSplitEmail_Click);
            // 
            // btnSplitEmailDelete
            // 
            this.btnSplitEmailDelete.Location = new System.Drawing.Point(443, 44);
            this.btnSplitEmailDelete.Name = "btnSplitEmailDelete";
            this.btnSplitEmailDelete.Size = new System.Drawing.Size(78, 24);
            this.btnSplitEmailDelete.TabIndex = 14;
            this.btnSplitEmailDelete.Text = "Xóa File";
            this.btnSplitEmailDelete.UseVisualStyleBackColor = true;
            this.btnSplitEmailDelete.Click += new System.EventHandler(this.btnSplitEmailDelete_Click);
            // 
            // btnSplitEmailAdd
            // 
            this.btnSplitEmailAdd.Location = new System.Drawing.Point(443, 9);
            this.btnSplitEmailAdd.Name = "btnSplitEmailAdd";
            this.btnSplitEmailAdd.Size = new System.Drawing.Size(78, 24);
            this.btnSplitEmailAdd.TabIndex = 15;
            this.btnSplitEmailAdd.Text = "Thêm File";
            this.btnSplitEmailAdd.UseVisualStyleBackColor = true;
            this.btnSplitEmailAdd.Click += new System.EventHandler(this.btnSplitEmailAdd_Click);
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myBackgroundWorker_DoWork);
            this.myBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.myBackgroundWorker_ProgressChanged);
            this.myBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myBackgroundWorker_RunWorkerCompleted);
            // 
            // myStatus
            // 
            this.myStatus.BackColor = System.Drawing.Color.Fuchsia;
            this.myStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.myStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.myStatus.Name = "myStatus";
            this.myStatus.Size = new System.Drawing.Size(39, 17);
            this.myStatus.Text = "Ready";
            // 
            // myStatusStrip
            // 
            this.myStatusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.myStatusStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.myStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myStatus});
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
            // mySaveFileDialog
            // 
            this.mySaveFileDialog.DefaultExt = "*.*";
            this.mySaveFileDialog.Filter = "Text Files (.txt)|*.txt";
            // 
            // rdProxy
            // 
            this.rdProxy.AutoSize = true;
            this.rdProxy.Location = new System.Drawing.Point(444, 181);
            this.rdProxy.Name = "rdProxy";
            this.rdProxy.Size = new System.Drawing.Size(51, 17);
            this.rdProxy.TabIndex = 14;
            this.rdProxy.Text = "Proxy";
            this.rdProxy.UseVisualStyleBackColor = true;
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
            this.Activated += new System.EventHandler(this.FileSplitterJoinner_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabSplitter.ResumeLayout(false);
            this.tabSplitter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitter)).EndInit();
            this.tabJoinner.ResumeLayout(false);
            this.tabJoinner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvJoinner)).EndInit();
            this.tabCheck.ResumeLayout(false);
            this.tabCheck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCheck)).EndInit();
            this.tabSplitEmailByGender.ResumeLayout(false);
            this.tabSplitEmailByGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvSplitEmail)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel myStatus;
        private System.Windows.Forms.ToolStripContainer myToolStripContainer;
        private System.Windows.Forms.StatusStrip myStatusStrip;
        private System.Windows.Forms.TabPage tabCheck;
        private System.Windows.Forms.DataGridView grvCheck;
        private System.Windows.Forms.Button btnCheckFile;
        private System.Windows.Forms.Button btnCheckDelete;
        private System.Windows.Forms.Button btnCheckAdd;
        private System.Windows.Forms.TabPage tabSplitEmailByGender;
        private System.Windows.Forms.DataGridView grvSplitEmail;
        private System.Windows.Forms.Button btnSplitEmail;
        private System.Windows.Forms.Button btnSplitEmailDelete;
        private System.Windows.Forms.Button btnSplitEmailAdd;
        private System.Windows.Forms.Button btnShowEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitterSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitterFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitterCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinnerSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinnerFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoinnerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitEmailSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitEmailFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn SplitEmailCount;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
        private System.Windows.Forms.CheckBox chkSplitterDeleted;
        private System.Windows.Forms.CheckBox chkJoinnerDeleted;
        private System.Windows.Forms.CheckBox chkSplitterGenderDeleted;
        private System.Windows.Forms.RadioButton rdPhone;
        private System.Windows.Forms.RadioButton rdEmail;
        private System.Windows.Forms.RadioButton rdProxy;
    }
}

