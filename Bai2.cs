using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            string content = sr.ReadToEnd();
            richTextBox1.Text = content;
            int charCount = content.Length;
            content = content.Replace("\r\n", "\r");
            
            Name = ofd.SafeFileName.ToString();
            string Url = fs.Name.ToString();
            int lineCount = richTextBox1.Lines.Count();
            //content = content.Replace('\r', '');
            string[] source = content.Split(new char[] { '.','?','!',';',':',',' }, StringSplitOptions.RemoveEmptyEntries);
            int wordcount = source.Count();
            label10.Text = Name;
            label9.Text = Url;
            label8.Text = lineCount.ToString();
            label7.Text = charCount.ToString();
            label6.Text = (wordcount - 1).ToString();
            richTextBox1.Text = content;
            fs.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
