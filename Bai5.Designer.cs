// File: Bai5.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    partial class Bai5
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

        private void InitializeComponent()
        {
            textBox_Path = new TextBox();
            label1 = new Label();
            button_Browse = new Button();
            button_Back = new Button();
            listView1 = new ListView();
            SuspendLayout();

            // textBox_Path
            textBox_Path.Location = new Point(68, 21);
            textBox_Path.Name = "textBox_Path";
            textBox_Path.Size = new Size(490, 27);
            textBox_Path.TabIndex = 0;

            // label1
            label1.AutoSize = true;
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "Path:";

            // button_Browse
            button_Browse.Location = new Point(579, 20);
            button_Browse.Name = "button_Browse";
            button_Browse.Size = new Size(94, 29);
            button_Browse.TabIndex = 2;
            button_Browse.Text = "Browse";
            button_Browse.UseVisualStyleBackColor = true;

            // button_Back
            button_Back.Location = new Point(694, 20);
            button_Back.Name = "button_Back";
            button_Back.Size = new Size(94, 29);
            button_Back.TabIndex = 2;
            button_Back.Text = "Back";
            button_Back.UseVisualStyleBackColor = true;

            // listView1
            listView1.Location = new Point(12, 70);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 368);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;

            // Bai5 Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(button_Back);
            Controls.Add(button_Browse);
            Controls.Add(label1);
            Controls.Add(textBox_Path);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBox_Path;
        private Label label1;
        private Button button_Browse;
        private Button button_Back;
        private ListView listView1;
    }
}