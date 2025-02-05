namespace WinFormsApp1
{
    partial class TeacherForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(25, 79);
            button1.Name = "button1";
            button1.Size = new Size(161, 58);
            button1.TabIndex = 0;
            button1.Text = "MyStudents";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(25, 143);
            button2.Name = "button2";
            button2.Size = new Size(161, 55);
            button2.TabIndex = 1;
            button2.Text = "Attendance/Absence";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(25, 204);
            button3.Name = "button3";
            button3.Size = new Size(161, 60);
            button3.TabIndex = 2;
            button3.Text = "AddNewStudent";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(213, 79);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(605, 214);
            listBox1.Sorted = true;
            listBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(490, 47);
            label1.TabIndex = 3;
            label1.Text = "Mr.Gholipour Computer Class";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(706, 49);
            button4.Name = "button4";
            button4.Size = new Size(112, 30);
            button4.TabIndex = 4;
            button4.Text = "Absent❌";
            button4.UseVisualStyleBackColor = true;
            button4.Visible = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            button5.ForeColor = Color.Green;
            button5.Location = new Point(586, 49);
            button5.Name = "button5";
            button5.Size = new Size(114, 30);
            button5.TabIndex = 5;
            button5.Text = "Present✅";
            button5.UseVisualStyleBackColor = true;
            button5.Visible = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(577, 43);
            button6.Name = "button6";
            button6.Size = new Size(241, 36);
            button6.TabIndex = 6;
            button6.Text = "Delete ⌫ ";
            button6.UseVisualStyleBackColor = true;
            button6.Visible = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(375, 43);
            button7.Name = "button7";
            button7.Size = new Size(121, 36);
            button7.TabIndex = 7;
            button7.Text = "Edit";
            button7.UseVisualStyleBackColor = true;
            button7.Visible = false;
            button7.Click += button7_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 352);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "TeacherForm";
            Text = "TeacherForm";
            FormClosing += TeacherForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private Label label1;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}