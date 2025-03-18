using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            button_Doc.Click += Button_Doc_Click;
            button_Tinh.Click += Button_Tinh_Click;
            button_Ghi.Click += Button_Ghi_Click;
        }

        // Đọc file
        private void Button_Doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string content = File.ReadAllText(openFileDialog.FileName);
                    richTextBox1.Text = content;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc file: " + ex.Message);
                }
            }
        }

        // Tính toán
        private void Button_Tinh_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBox1.Text.Split('\n');
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                string expression = line.Trim();
                if (string.IsNullOrWhiteSpace(expression)) continue;

                try
                {
                    string[] parts = expression.Split(' ');
                    if (parts.Length == 3)
                    {
                        int num1 = int.Parse(parts[0]);
                        string op = parts[1];
                        int num2 = int.Parse(parts[2]);
                        int res = 0;

                        switch (op)
                        {
                            case "+":
                                res = num1 + num2;
                                break;
                            case "-":
                                res = num1 - num2;
                                break;
                            case "*":
                                res = num1 * num2;
                                break;
                            case "/":
                                if (num2 != 0)
                                    res = num1 / num2;
                                else
                                    throw new DivideByZeroException();
                                break;
                            default:
                                throw new Exception("Phép toán không hợp lệ!");
                        }

                        result.AppendLine($"{expression} = {res}");
                    }
                    else
                    {
                        result.AppendLine($"Dòng không hợp lệ: {expression}");
                    }
                }
                catch (Exception ex)
                {
                    result.AppendLine($"Lỗi ở dòng: {expression} ({ex.Message})");
                }
            }

            richTextBox2.Text = result.ToString();
        }

        // Ghi kết quả ra file
        private void Button_Ghi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output.txt";
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, richTextBox2.Text);
                    MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi ghi file: " + ex.Message);
                }
            }
        }
    }
}
