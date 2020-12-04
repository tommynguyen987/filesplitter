using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileSplitterJoiner
{
	public partial class FileSplitterJoinner : Form
	{
		public FileSplitterJoinner()
		{
			InitializeComponent();
		}

		private void txtSplitterRows_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar)) e.Handled = true;         //Just Digits
			if (e.KeyChar == (char)8) e.Handled = false;            //Allow Backspace
		}

		private void btnSplitterAdd_Click(object sender, EventArgs e)
		{          
			var dr = myOpenFileDialog.ShowDialog();
			if (dr == DialogResult.OK)
			{
                foreach (var filename in myOpenFileDialog.FileNames)
                {
                    var index = grvSplitter.Rows.Add();
                    grvSplitter.Rows[index].Cells["SplitterSTT"].Value = (index + 1);
                    grvSplitter.Rows[index].Cells["SplitterFilePath"].Value = filename;
                }
			}            
		}

		private void btnSplitterDelete_Click(object sender, EventArgs e)
		{
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?","Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in grvSplitter.Rows)
                {
                    if (row.Selected)
                    {
                        int index = row.Index;
                        grvSplitter.Rows.Remove(row);
                    }
                }
                grvSplitter.Refresh();
            }            
		}

        private void grvSplitter_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {            
            for (int i = 0; i < grvSplitter.Rows.Count; i++)
            {
                grvSplitter.Rows[i].Cells["SplitterSTT"].Value = i+1;
            }           
        }

        private void btnSplitFile_Click(object sender, EventArgs e)
		{
            if (string.IsNullOrEmpty(txtSplitterRows.Text))
            {
                MessageBox.Show("Nhập số dòng trong 1 file được tách!");
                txtSplitterRows.Focus();
            }
            else {
                int rows = int.Parse(txtSplitterRows.Text);
                SplitFile(rows);
                //myBackgroundWorker.RunWorkerAsync(rows);
            }
		}

        private void btnJoinnerAdd_Click(object sender, EventArgs e)
        {
            var dr = myOpenFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {                
                foreach (var filename in myOpenFileDialog.FileNames)
                {
                    var index = grvJoinner.Rows.Add();
                    grvJoinner.Rows[index].Cells["JoinnerSTT"].Value = (index + 1);
                    grvJoinner.Rows[index].Cells["JoinnerFilePath"].Value = filename;
                }                
            }
        }

        private void btnJoinnerDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in grvJoinner.Rows)
                {
                    if (row.Selected)
                    {
                        int index = row.Index;
                        grvJoinner.Rows.Remove(row);
                    }
                }
                grvJoinner.Refresh();
            }
        }

        private void grvJoinner_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < grvJoinner.Rows.Count; i++)
            {
                grvJoinner.Rows[i].Cells["JoinnerSTT"].Value = i + 1;
            }
        }

        private void btnJoinFile_Click(object sender, EventArgs e)
        {
            //myBackgroundWorker.RunWorkerAsync();
            JoinFile();
        }

        private void EnableControl(bool isEnabled)
        {
            btnSplitFile.Enabled = isEnabled;
            btnSplitterAdd.Enabled = isEnabled;
            btnSplitterDelete.Enabled = isEnabled;
        }

        private void SplitFile(int rows)
        {
            try
            {                
                EnableControl(false);
                int index = 0;
                foreach (DataGridViewRow row in grvSplitter.Rows)
                {
                    string path = grvSplitter.Rows[index].Cells["SplitterFilePath"].Value.ToString();
                    myStatus1.Visible = false;
                    myStatusStrip.Refresh();             
                    int len = File.ReadAllLines(path)
                                .Where(arg => !string.IsNullOrWhiteSpace(arg))
                                .Distinct()
                                .Count();
                    int count = 0;
                    if (len % rows == 0)
                    {
                        count = (int)len / rows;
                    }
                    else
                    {
                        count = (int)(len / rows) + 1;
                    }
                    for (int i = 0; i < count; i++)
                    {
                        var lines = File.ReadAllLines(path)
                                    .Where(arg => !string.IsNullOrWhiteSpace(arg))
                                    .Distinct()
                                    .Skip(i * rows)
                                    .Take(rows)
                                    .ToList();
                        string content = "";
                        foreach (var line in lines)
                        {
                            content += line + Environment.NewLine;
                        }
                        string filename = path.Replace(".txt", "") + (i + 1) + ".txt";
                        myStatus2.Text = "Đang tạo file: " + filename.Split('\\')[filename.Split('\\').Length - 1];
                        myStatus2.Visible = true;
                        myStatusStrip.Refresh();
                        using (var fs = new FileStream(filename, FileMode.Create,
                        FileAccess.Write, FileShare.None, 4096, FileOptions.None))
                        {
                            fs.Write(UnicodeEncoding.UTF8.GetBytes(content), 0, content.Length);
                        }
                    }
                    index++;
                }
                MessageBox.Show("Tách file thành công!");
                grvSplitter.Rows.Clear();
                txtSplitterRows.Text = "";
                myStatus1.Visible = true;
                myStatus2.Visible = false;
                EnableControl(true);                         
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tách file!" + System.Environment.NewLine + ex.Message);
                EnableControl(true);
            } 
        }

        private void JoinFile()
        {
            try
            {
                //EnableControl(false);
                int index = 0;
                string filename = grvJoinner.Rows[index].Cells["JoinnerFilePath"].Value.ToString().Replace("1.txt", ".txt");
                foreach (DataGridViewRow row in grvJoinner.Rows)
                {
                    string path = grvJoinner.Rows[index].Cells["JoinnerFilePath"].Value.ToString();
                    myStatus1.Visible = false;
                    myStatusStrip.Refresh();
                    string content = File.ReadAllText(path);
                    myStatus2.Text = "Đang ghép file:" + filename.Split('\\')[filename.Split('\\').Length - 1];
                    myStatus2.Visible = true;
                    myStatusStrip.Refresh();
                    using (var fs = new FileStream(filename, FileMode.Append,
                    FileAccess.Write, FileShare.None, 4096, FileOptions.None))
                    {
                        fs.Write(UnicodeEncoding.UTF8.GetBytes(content), 0, content.Length);
                    }
                    index++;
                }
                MessageBox.Show("Ghép file thành công!");
                grvJoinner.Rows.Clear();
                myStatus1.Visible = true;
                myStatus2.Visible = false;
                myProgress.Visible = false;
                //EnableControl(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi ghép file!" + System.Environment.NewLine + ex.Message);
                //EnableControl(true);
                myProgress.Visible = false;
            }
        }

        private void myBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!e.Cancel)
            {
                myProgress.Visible = true;
                int progress = 0;
                // do some work  
                myBackgroundWorker.ReportProgress(progress++);  // this is the key       
                JoinFile();
            }
        }

        private void myBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            myProgress.Value = e.ProgressPercentage;
            myStatus1.Text = e.UserState.ToString();
        }

        private void myBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            myProgress.Value = myProgress.Maximum;
            myStatus1.Text = "Complete!";
        }        
    }
}
