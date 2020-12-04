namespace FileSplitterJoiner
{
    partial class Handler
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
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(10, 59);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(293, 23);
            this.myProgressBar.TabIndex = 0;
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblStatus1.Location = new System.Drawing.Point(7, 12);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(79, 13);
            this.lblStatus1.TabIndex = 1;
            this.lblStatus1.Text = "Đang tách file: ";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.ForeColor = System.Drawing.Color.Magenta;
            this.lblStatus2.Location = new System.Drawing.Point(7, 32);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(73, 13);
            this.lblStatus2.TabIndex = 1;
            this.lblStatus2.Text = "Đang tạo file: ";
            // 
            // Handler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 92);
            this.ControlBox = false;
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.myProgressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Handler";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Handling ...";
            this.Load += new System.EventHandler(this.Handler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus2;
    }
}