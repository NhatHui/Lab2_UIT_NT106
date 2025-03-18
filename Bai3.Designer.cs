using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Bai3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.button_Doc = new System.Windows.Forms.Button();
            this.button_Tinh = new System.Windows.Forms.Button();
            this.button_Ghi = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button_Doc
            // 
            this.button_Doc.Location = new System.Drawing.Point(50, 31);
            this.button_Doc.Name = "button_Doc";
            this.button_Doc.Size = new System.Drawing.Size(155, 68);
            this.button_Doc.TabIndex = 0;
            this.button_Doc.Text = "Đọc";
            this.button_Doc.UseVisualStyleBackColor = true;
            // 
            // button_Tinh
            // 
            this.button_Tinh.Location = new System.Drawing.Point(322, 31);
            this.button_Tinh.Name = "button_Tinh";
            this.button_Tinh.Size = new System.Drawing.Size(155, 68);
            this.button_Tinh.TabIndex = 0;
            this.button_Tinh.Text = "Tính";
            this.button_Tinh.UseVisualStyleBackColor = true;
            // 
            // button_Ghi
            // 
            this.button_Ghi.Location = new System.Drawing.Point(567, 31);
            this.button_Ghi.Name = "button_Ghi";
            this.button_Ghi.Size = new System.Drawing.Size(155, 68);
            this.button_Ghi.TabIndex = 0;
            this.button_Ghi.Text = "Ghi";
            this.button_Ghi.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 322);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(417, 116);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(360, 322);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button_Ghi);
            this.Controls.Add(this.button_Tinh);
            this.Controls.Add(this.button_Doc);
            this.Name = "Bai3";
            this.Text = "Bai3";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button_Doc;
        private System.Windows.Forms.Button button_Tinh;
        private System.Windows.Forms.Button button_Ghi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}
