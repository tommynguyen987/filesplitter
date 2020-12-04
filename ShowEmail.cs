using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FileSplitterJoiner
{
    public partial class frmShowEmail : Form
    {
        public static bool isSaved = false;
        public frmShowEmail()
        {
            InitializeComponent();
        }
        
        private void LoadData()
        {
            var path = FileSplitterJoinner.FilePath;
            var lines = File.ReadAllLines(path)
                            .Where(arg => !string.IsNullOrWhiteSpace(arg))
                            .Distinct()
                            .ToList();
            foreach (var line in lines)
            {
                var index = grvListEmails.Rows.Add();
                grvListEmails.Rows[index].Cells["Operation"].Value = false;
                grvListEmails.Rows[index].Cells["STT"].Value = (index + 1);
                grvListEmails.Rows[index].Cells["Email"].Value = line;
            }
        }

        private void frmShowEmail_Load(object sender, EventArgs e)
        {
            LoadData();
            myCount.Text = "";
        }

        int count = 0;
        private void grvListEmails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            foreach (DataGridViewRow row in grvListEmails.Rows)
            {
                if (!row.Selected) continue;
                myStatus.Text = "Checked: ";
                if ((bool)row.Cells["Operation"].Value)
                {
                    row.Cells["Operation"].Value = false;
                    if (count > 0)
                    {
                        count--;
                        myCount.Text = count.ToString();
                    }
                }
                else
                {
                    row.Cells["Operation"].Value = true;
                    count++;
                    myCount.Text = count.ToString();
                }
                break;
            }
            if (count == 0) 
            {
                myStatus.Text = "Ready";
                myCount.Text = "";
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            myStatus.Text = "Checked: ";
            foreach (DataGridViewRow row in grvListEmails.Rows)
            {
                row.Cells["Operation"].Value = true;
                count++;
            }
            myCount.Text = count.ToString();
        }

        private void btnUnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grvListEmails.Rows)
            {
                row.Cells["Operation"].Value = false;
            }
            myStatus.Text = "Ready";
            myCount.Text = "";
            count = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {                    
            mySaveFileDialog.Filter = "Text files|*.txt";
            mySaveFileDialog.Title = "Save a text file";
            isSaved = true;
            mySaveFileDialog.FileName = FileSplitterJoinner.FilePath;
            //var dr = mySaveFileDialog.ShowDialog();
            //if (dr == DialogResult.OK)
            //{
                var emailsMale = "";
                var emailsFemale = "";
                var malePath = FileSplitterJoinner.FilePath.Replace(".txt", "_Male.txt");
                var femalePath = FileSplitterJoinner.FilePath.Replace(".txt", "_Female.txt");
                var listEmails = new List<string>();
                foreach (DataGridViewRow row in grvListEmails.Rows)
                {
                    if ((bool)row.Cells["Operation"].Value == true)
                    {
                        emailsMale += row.Cells["Email"].Value.ToString() + System.Environment.NewLine;
                        listEmails.Add(row.Cells["Email"].Value.ToString());
                        row.DefaultCellStyle.BackColor = Color.Aqua;
                    }
                    else emailsFemale += row.Cells["Email"].Value.ToString() + System.Environment.NewLine;
                }
                using (var fs = new FileStream(malePath, FileMode.Create,
                       FileAccess.Write, FileShare.None, 4096, FileOptions.None)) fs.Write(UnicodeEncoding.UTF8.GetBytes(emailsMale), 0, emailsMale.Length);

                using (var fs = new FileStream(femalePath, FileMode.Create,
                       FileAccess.Write, FileShare.None, 4096, FileOptions.None)) fs.Write(UnicodeEncoding.UTF8.GetBytes(emailsFemale), 0, emailsFemale.Length);

                MessageBox.Show("Lưu file thành công!");
                myStatus.Text = "Ready";
                myCount.Text = "";
                count = 0;

                grvListEmails.Refresh();
            //}            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            grvListEmails.Rows.Clear();
            myStatus.Text = "Ready";
            myCount.Text = "";
            count = 0;
            LoadData();            
        }

        private void grvListEmails_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (var i = 0; i < grvListEmails.Rows.Count; i++) grvListEmails.Rows[i].Cells["STT"].Value = i + 1;
        }
    }
}
