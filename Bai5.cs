// File: Bai5.cs
using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Tên file", 250);
            listView1.Columns.Add("Kích thước", 100);
            listView1.Columns.Add("Đuôi mở rộng", 100);
            listView1.Columns.Add("Ngày tạo", 150);

            button_Browse.Click += Button_Browse_Click;
            button_Back.Click += Button_Back_Click;
        }

        private void Button_Browse_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    textBox_Path.Text = fbd.SelectedPath;
                    LoadFiles(fbd.SelectedPath);
                }
            }
        }

        private void Button_Back_Click(object sender, EventArgs e)
        {
            string currentPath = textBox_Path.Text;
            if (!string.IsNullOrEmpty(currentPath))
            {
                string parentPath = Directory.GetParent(currentPath)?.FullName;
                if (!string.IsNullOrEmpty(parentPath))
                {
                    textBox_Path.Text = parentPath;
                    LoadFiles(parentPath);
                }
            }
        }

        private void LoadFiles(string path)
        {
            try
            {
                listView1.Items.Clear();
                DirectoryInfo di = new DirectoryInfo(path);
                FileInfo[] files = di.GetFiles();
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.Length.ToString());
                    item.SubItems.Add(file.Extension);
                    item.SubItems.Add(file.CreationTime.ToString());
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
