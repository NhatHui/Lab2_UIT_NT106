using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static WindowsFormsApp2.bai4;

namespace WindowsFormsApp2
{
    public partial class bai4: Form
    {
        [Serializable]
        public class Student
        {
            public string Name { get; set; }
            public string MSSV { get; set; }
            public string Phone { get; set; }
            public float DIEMTOAN { get; set; }
            public float DIEMVAN { get; set; }
            public double AvgScore { get; set; }
            public Student(string mssv, string name,  string phone, float diemtoan, float diemvan)

            {
                MSSV = mssv;
                Name = name;
                Phone = phone;
                DIEMTOAN = diemtoan;
                DIEMVAN = diemvan;
            }

        }
        public bai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mssv = textBox1.Text;
            string hoten = textBox2.Text;
            string dienthoai = textBox3.Text;

            if (mssv == "" || hoten == "" || dienthoai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float diemtoan;
            float diemvan;
            if (!float.TryParse(textBox4.Text, out diemtoan) || diemtoan < 0 || diemtoan > 10)
            {
                MessageBox.Show("Vui lòng nhập số thực từ 0 đến 10 cho điểm toán!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox4.Focus();
                return;
            }

            if (!float.TryParse(textBox5.Text, out diemvan) || diemvan < 0 || diemvan > 10)
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho điểm văn!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus();
                return;
            }

            Student student = new Student(mssv, hoten, dienthoai, diemtoan, diemvan);
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream stream = new MemoryStream();
            formatter.Serialize(stream, student);
            byte[] bytes = stream.ToArray();
            File.WriteAllBytes(@"D:\UIT\HK2\LTMCB\Thuc Hanh\lab\WindowsFormsApp2\input.txt", bytes);

            MessageBox.Show("Ghi file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String path = @"D:\UIT\HK2\LTMCB\Thuc Hanh\lab\WindowsFormsApp2\input.txt";
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Student student = (Student)formatter.Deserialize(fs);
                student.AvgScore = (student.DIEMTOAN + student.DIEMVAN) / 2;
                MessageBox.Show($"MSSV: {student.MSSV}\nHọ tên: {student.Name}\nSĐT: {student.Phone}\n" +
                                $"Điểm Toán: {student.DIEMTOAN}\nĐiểm Văn: {student.DIEMVAN}\n" +
                                $"Điểm TB: {student.AvgScore:F1}",
                                "Thông tin sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream stream = new MemoryStream();
                formatter.Serialize(stream, student);
                byte[] bytes = stream.ToArray();
                File.WriteAllBytes(@"D:\UIT\HK2\LTMCB\Thuc Hanh\lab\WindowsFormsApp2\output.txt", bytes);


            }
        }
    }
}
