using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fname = textBox1.Text;
            string lname = textBox2.Text;
            if (fname != "" && lname != "")
            {
                Teacher.AddStudent(fname, lname, false);
                MessageBox.Show("Add Successfully");
                textBox1.Text = "";
                textBox2.Text = "";
            }
            else
            {
                MessageBox.Show("invalid input");
            }
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            this.Location = new Point((screenWidth - formWidth) / 2, (screenHeight - formHeight) / 2);
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                    e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    e.SuppressKeyPress = true;
                string fname = textBox1.Text;
                string lname = textBox2.Text;
                if (fname != "" && lname != "")
                {
                    Teacher.AddStudent(fname, lname, false);
                    MessageBox.Show("Add Successfully");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("invalid input");
                }
            }
        }
    }
}
