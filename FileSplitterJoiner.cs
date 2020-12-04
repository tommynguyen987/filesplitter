using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FileSplitterJoiner
{
    public partial class FileSplitterJoinner : Form
    {
        const int SPLIT_FILE = 0;
        const int JOIN_FILE = 1;
        const int CHECK_FILE = 2;
        const int SPLIT_GENDER_FILE = 3;
        int rowsCount = 0;
        public static string FilePath = string.Empty;
                
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
            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;
            foreach (var filename in myOpenFileDialog.FileNames)
            {
                var index = grvSplitter.Rows.Add();                    
                grvSplitter.Rows[index].Cells["SplitterSTT"].Value = (index + 1);
                grvSplitter.Rows[index].Cells["SplitterFilePath"].Value = filename;
                grvSplitter.Rows[index].Cells["SplitterCount"].Value = GetLength(filename);
            }
        }

        private void btnSplitterDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel) return;
            foreach (DataGridViewRow row in grvSplitter.Rows)
            {
                if (row.Selected) grvSplitter.Rows.Remove(row);
            }
            grvSplitter.Refresh();
        }

        private void grvSplitter_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (var i = 0; i < grvSplitter.Rows.Count; i++) grvSplitter.Rows[i].Cells[0].Value = i + 1;
        }

        private void btnSplitFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSplitterRows.Text))
            {
                MessageBox.Show("Nhập số dòng trong 1 file được tách!");
                txtSplitterRows.Focus();
            }
            else
            {
                EnableControl(false);
                rowsCount = int.Parse(txtSplitterRows.Text);
                myBackgroundWorker.RunWorkerAsync(SPLIT_FILE);                
            }
        }

        private void btnJoinnerAdd_Click(object sender, EventArgs e)
        {
            var dr = myOpenFileDialog.ShowDialog();
            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;
            foreach (var filename in myOpenFileDialog.FileNames)
            {
                var index = grvJoinner.Rows.Add();
                grvJoinner.Rows[index].Cells["JoinnerSTT"].Value = (index + 1);
                grvJoinner.Rows[index].Cells["JoinnerFilePath"].Value = filename;
                grvJoinner.Rows[index].Cells["JoinnerCount"].Value = GetLength(filename);
            }
        }

        private void btnJoinnerDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel) return;
            foreach (DataGridViewRow row in grvJoinner.Rows)
            {
                if (row.Selected) grvJoinner.Rows.Remove(row);
            }
            grvJoinner.Refresh();
        }

        private void grvJoinner_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (var i = 0; i < grvJoinner.Rows.Count; i++) grvJoinner.Rows[i].Cells["JoinnerSTT"].Value = i + 1;
        }

        private void btnJoinFile_Click(object sender, EventArgs e)
        {
            EnableControl(false);
            var dr = mySaveFileDialog.ShowDialog();
            if (dr == DialogResult.OK || dr == DialogResult.Yes) myBackgroundWorker.RunWorkerAsync(JOIN_FILE);
        }

        private void btnCheckAdd_Click(object sender, EventArgs e)
        {
            var dr = myOpenFileDialog.ShowDialog();
            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;
            foreach (var filename in myOpenFileDialog.FileNames)
            {
                var index = grvCheck.Rows.Add();
                grvCheck.Rows[index].Cells["CheckSTT"].Value = (index + 1);
                grvCheck.Rows[index].Cells["CheckFilePath"].Value = filename;
                grvCheck.Rows[index].Cells["CheckCount"].Value = GetLength(filename);
            }
        }

        private void btnCheckDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel) return;
            foreach (DataGridViewRow row in grvCheck.Rows)
            {
                if (row.Selected) grvCheck.Rows.Remove(row);
            }
            grvCheck.Refresh();
        }

        private void grvCheck_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (var i = 0; i < grvCheck.Rows.Count; i++) grvCheck.Rows[i].Cells["CheckSTT"].Value = i + 1;
        }   

        private void btnCheckFile_Click(object sender, EventArgs e)
        {
            EnableControl(false);
            myBackgroundWorker.RunWorkerAsync(CHECK_FILE);
        }

        private void grvSplitEmail_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (var i = 0; i < grvSplitEmail.Rows.Count; i++) grvSplitEmail.Rows[i].Cells["SplitEmailSTT"].Value = i + 1;
        }

        private void btnSplitEmailAdd_Click(object sender, EventArgs e)
        {
            var dr = myOpenFileDialog.ShowDialog();
            if (dr == DialogResult.No || dr == DialogResult.Cancel) return;
            foreach (var filename in myOpenFileDialog.FileNames)
            {
                var index = grvSplitEmail.Rows.Add();
                grvSplitEmail.Rows[index].Cells["SplitEmailSTT"].Value = (index + 1);
                grvSplitEmail.Rows[index].Cells["SplitEmailFilePath"].Value = filename;
                grvSplitEmail.Rows[index].Cells["SplitEmailCount"].Value = GetLength(filename);
            }
        }

        private void btnSplitEmailDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Bạn có chắc muốn xóa dòng này không?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel) return;
            foreach (DataGridViewRow row in grvSplitEmail.Rows)
            {
                if (row.Selected) grvSplitEmail.Rows.Remove(row);
            }
            grvSplitEmail.Refresh();
        }

        private void btnShowEmail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grvSplitEmail.Rows)
            {
                if (!row.Selected) continue;
                var index = row.Index;
                FilePath = grvSplitEmail.Rows[index].Cells["SplitEmailFilePath"].Value.ToString();
                break;
            }
            var form = new frmShowEmail();
            form.ShowDialog();
        }   

        private void btnSplitEmail_Click(object sender, EventArgs e)
        {
            EnableControl(false);
            myBackgroundWorker.RunWorkerAsync(SPLIT_GENDER_FILE);
        }

        private void FileSplitterJoinner_Activated(object sender, EventArgs e)
        {
            if (!frmShowEmail.isSaved) return;
            foreach (DataGridViewRow row in grvSplitEmail.Rows)
            {
                if (!row.Selected) continue;
                grvSplitEmail.Rows.Remove(row);
                break;
            }
            grvSplitEmail.Refresh();
            frmShowEmail.isSaved = false;
        }     

        private void EnableControl(bool isEnabled)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    btnSplitFile.Enabled = isEnabled;
                    btnSplitterAdd.Enabled = isEnabled;
                    btnSplitterDelete.Enabled = isEnabled;
                    chkSplitterDeleted.Enabled = isEnabled;
                    break;
                case 1:
                    btnJoinFile.Enabled = isEnabled;
                    btnJoinnerAdd.Enabled = isEnabled;
                    btnJoinnerDelete.Enabled = isEnabled;
                    chkJoinnerDeleted.Enabled = isEnabled;
                    break;
                case 2:
                    btnCheckFile.Enabled = isEnabled;
                    btnCheckAdd.Enabled = isEnabled;
                    btnCheckDelete.Enabled = isEnabled;

                    break;
                case 3:
                    btnSplitEmail.Enabled = isEnabled;
                    btnSplitEmailAdd.Enabled = isEnabled;
                    btnSplitEmailDelete.Enabled = isEnabled;
                    btnShowEmail.Enabled = isEnabled;
                    chkSplitterGenderDeleted.Enabled = isEnabled;
                    break;
            }
        }

        private static bool IsValidEmail(string email)
        {
            //regular expression 
            var pattern = @"^[a-z].*?@(?:yahoo\.com|yahoo\.com\.vn|gmail\.com|hotmail\.com)$";
            //Set up regex object 
            var reg = new Regex(pattern, RegexOptions.IgnoreCase);
            return reg.IsMatch(email);
        }

        private static bool IsValidPhone(string phone)
        {
            //regular expression 
            var pattern = @"(09|01[2|6|8|9])+([0-9]{8})\b";
            //Set up regex object 
            var reg = new Regex(pattern, RegexOptions.IgnoreCase);
            return reg.IsMatch(phone);
        }

        private static bool IsValidProxy(string proxy)
        {
            //regular expression 
            var pattern = @"(\d{1,3}\.){3}\d{1,3}:\d{2,5}";
            //Set up regex object 
            var reg = new Regex(pattern, RegexOptions.IgnoreCase);
            return reg.IsMatch(proxy);
        }

        private static string GetValidEmail(string sEmail)
        {
            return sEmail.Replace(";", "")
                         .Replace("#", "")
                         .Replace("!","")
                         .Replace("%","")
                         .Replace("$", "")
                         .Replace("&", "")
                         .Replace("+", "")
                         .Replace("=", "")
                         .Replace("^", "")
                         .ToLower()
                         .Trim();
        }

        private int GetLength(string path)
        {
            return File.ReadAllLines(path)
                                .Where(arg => !string.IsNullOrWhiteSpace(arg))
                                .Distinct()
                                .Count();
        }

        private void SplitFile(int rows)
        {
            try
            {   
                foreach (DataGridViewRow row in grvSplitter.Rows)
                {
                    var path = row.Cells["SplitterFilePath"].Value.ToString();
                    var len = GetLength(path);
                    var count = 0;
                    if (len % rows == 0) count = (int)len / rows;
                    else count = (int)(len / rows) + 1;
                    for (var i = 0; i < count; i++)
                    {
                        var filename = path.Replace(".txt", (i + 1) + ".txt");
                        myStatus.Text = "Đang tạo file: " + filename.Split('\\')[filename.Split('\\').Length - 1];
                        myStatusStrip.Refresh();
                        var lines = File.ReadAllLines(path)
                                    .Where(arg => !string.IsNullOrWhiteSpace(arg)).Where(arg => !string.IsNullOrEmpty(arg))
                                    .Distinct()
                                    .Skip(i * rows)
                                    .Take(rows)
                                    .ToList();
                        var content = "";
                        foreach (var line in lines)
                        {
                            if (string.IsNullOrWhiteSpace(line) || string.IsNullOrEmpty(line)) continue;
                            if (line.Contains(","))
                            {
                                var l = line.Split(',');
                                foreach (var item in l)
                                {
                                    content += item + Environment.NewLine;
                                }
                            }
                            else
                                content += line + Environment.NewLine; 
                        }
                        using (var fs = new FileStream(filename, FileMode.Create,
                        FileAccess.Write, FileShare.None, 4096, FileOptions.None))
                        {
                            fs.Write(UnicodeEncoding.UTF8.GetBytes(content), 0, content.Length);
                        }
                    }
                    if (chkSplitterDeleted.Checked) File.Delete(path);
                }
                MessageBox.Show("Tách file thành công!");
                myStatus.Text = "Ready";
                myStatusStrip.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi tách file!" + System.Environment.NewLine + ex.Message);
                myStatus.Text = "Error";
                myStatusStrip.Refresh();
            } 
        }

        private void JoinFile()
        {
            try
            {                
                var fileName = mySaveFileDialog.FileName;
                foreach (DataGridViewRow row in grvJoinner.Rows)
                {
                    var path = row.Cells["JoinnerFilePath"].Value.ToString();
                    myStatus.Text = "Đang ghép file: " + path.Split('\\')[path.Split('\\').Length - 1];
                    myStatusStrip.Refresh();
                    var lines = File.ReadAllLines(path)
                                    .Where(arg => !string.IsNullOrWhiteSpace(arg)).Where(arg => !string.IsNullOrEmpty(arg))
                                    .Distinct()
                                    .ToList();
                    var content = "";
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || string.IsNullOrEmpty(line)) continue;
                        if (line.Contains(","))
                        {
                            var l = line.Split(',');
                            foreach (var item in l) 
                            {
                                content += item + Environment.NewLine;
                            }
                        }
                        else
                            content += line + Environment.NewLine;
                    }
                    if (chkJoinnerDeleted.Checked) File.Delete(path);
                    TextWriter tw = new StreamWriter(fileName, true);
                    tw.WriteLine(content);
                    tw.Close();
                }
                MessageBox.Show("Ghép file thành công!");
                myStatus.Text = "Ready";
                myStatusStrip.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi ghép file!" + System.Environment.NewLine + ex.Message);
                myStatus.Text = "Error";
                myStatusStrip.Refresh();
            }
        }

        private void CheckFile()
        {
            try
            {
                foreach (DataGridViewRow row in grvCheck.Rows)
                {
                    var path = row.Cells["CheckFilePath"].Value.ToString();
                    myStatus.Text = "Đang kiểm tra file: " + path.Split('\\')[path.Split('\\').Length - 1];
                    myStatusStrip.Refresh();
                    var lines = File.ReadAllLines(path)
                                .Where(arg => !string.IsNullOrWhiteSpace(arg)).Where(arg => !string.IsNullOrEmpty(arg))
                                .Distinct()
                                .ToList();
                    var content = "";
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || string.IsNullOrEmpty(line)) continue;
                        if (line.Contains(","))
                        {
                            var l = line.Split(',');
                            foreach (var item in l)
                            {
                                if (string.IsNullOrEmpty(item)) continue;
                                if (rdEmail.Checked)
                                {
                                    if (IsValidEmail(GetValidEmail(line)))
                                    {
                                        if(content.Length != 0) content += ",";
                                        content += GetValidEmail(line) + Environment.NewLine;
                                        
                                    }
                                }
                                else if (rdPhone.Checked)
                                {
                                    if (IsValidPhone(line)) content += line + Environment.NewLine;
                                }
                                else if (rdProxy.Checked)
                                {
                                    if (IsValidProxy(line)) content += line + Environment.NewLine;
                                }                                
                            }
                        }
                        else
                        {
                            if (rdEmail.Checked)
                            {
                                if (IsValidEmail(GetValidEmail(line)))
                                {
                                    if (content.Length != 0) content += ",";
                                    content += GetValidEmail(line) + Environment.NewLine;
                                }
                            }
                            else if (rdPhone.Checked)
                            {
                                if (IsValidPhone(line)) content += line + Environment.NewLine;
                            }
                            else if (rdProxy.Checked)
                            {
                                if (IsValidProxy(line)) content += line + Environment.NewLine;
                            }
                        }                            
                    }                    
                    using (var fs = new FileStream(path.Replace(".txt", "_checked.txt"), FileMode.Create, FileAccess.ReadWrite, FileShare.None, 4096, FileOptions.None))
                        fs.Write(UnicodeEncoding.UTF8.GetBytes(content), 0, content.Length);
                }
                MessageBox.Show("Kiểm tra file thành công!");
                myStatus.Text = "Ready";
                myStatusStrip.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xảy ra lỗi khi kiểm tra file!" + System.Environment.NewLine + ex.Message);
                myStatus.Text = "Error";
                myStatusStrip.Refresh();
            }
        }
        
        private bool isFemale(string input)
        {
            var len = grvSplitEmail.Rows[0].Cells["SplitEmailFilePath"].Value.ToString().Split('\\').Length;
            var file = grvSplitEmail.Rows[0].Cells["SplitEmailFilePath"].Value.ToString().Split('\\')[len-1];
            var path = grvSplitEmail.Rows[0].Cells["SplitEmailFilePath"].Value.ToString().Replace("EmailList\\"+file, "femaleGender.txt");
            input = input.Replace("@gmail.com","");
            var lines = File.ReadAllLines(path)
                            .Where(arg => !string.IsNullOrWhiteSpace(arg) 
                                && input.Contains(arg) 
                                && (!input.Contains("boss") || !input.Contains("mr"))
                                )
                            .ToList();
            return lines.Count > 0;
        }
        
        private void SplitEmailByGender()
        {
            try
            {
                foreach (DataGridViewRow row in grvSplitEmail.Rows)
                {
                    var path = row.Cells["SplitEmailFilePath"].Value.ToString();
                    var malePath = path.Replace("EmailList", "EmailList_Male").Replace(".txt", "_Male.txt");
                    var femalePath = path.Replace("EmailList", "EmailList_Female").Replace(".txt", "_Female.txt");
                    myStatus.Text = "Đang tách file: " + path.Split('\\')[path.Split('\\').Length - 1];
                    myStatusStrip.Refresh();
                    var lines = File.ReadAllLines(path)
                                .Where(arg => !string.IsNullOrWhiteSpace(arg)).Where(arg => !string.IsNullOrEmpty(arg))
                                .Distinct()
                                .ToList();
                    string emailsMale = "", emailsFemale = "";
                    foreach (var line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line) || string.IsNullOrEmpty(line)) continue;
                        var email = GetValidEmail(line);
                        if (!IsValidEmail(email)) continue;
                        if (isFemale(email)) emailsFemale += email + Environment.NewLine;
                        else emailsMale += email + Environment.NewLine;
                    }
                    if (emailsMale.Length == 0 || emailsFemale.Length == 0) continue;
                    using (var fs = new FileStream(malePath, FileMode.Create,
                            FileAccess.Write, FileShare.None, 4096, FileOptions.None)) fs.Write(UnicodeEncoding.UTF8.GetBytes(emailsMale), 0, emailsMale.Length);
                    using (var fs = new FileStream(femalePath, FileMode.Create,
                                FileAccess.Write, FileShare.None, 4096, FileOptions.None)) fs.Write(UnicodeEncoding.UTF8.GetBytes(emailsFemale), 0, emailsFemale.Length);
                    if (chkSplitterGenderDeleted.Checked) File.Delete(path);
                }
                MessageBox.Show("Tách email thành công!");
                myStatus.Text = "Ready";
                myStatusStrip.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tách email!" + System.Environment.NewLine + ex.Message);
            } 
        }

        private void myBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            switch (e.Argument.ToString())
            {
                case "0":
                    SplitFile(rowsCount);
                    txtSplitterRows.Text = "";
                    grvSplitter.Rows.Clear();
                    break;
                case "1":
                    JoinFile();
                    grvJoinner.Rows.Clear();
                    break;
                case "2":
                    CheckFile();
                    grvCheck.Rows.Clear();
                    break;
                case "3":
                    SplitEmailByGender();
                    grvSplitEmail.Rows.Clear();
                    break;
            }            
            EnableControl(true);
        }

        private void myBackgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            myStatus.Text = e.UserState.ToString();
        }

        private void myBackgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            myStatus.Text = "Done";
        }                            
    }
}
