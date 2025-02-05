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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Teacher.GetStudentsList();
            listBox1.DisplayMember = "DisplayStudentInfo";
            listBox1.ValueMember = "Id";
            listBox1.Visible = true;
            button6.Visible = true;
            button4.Visible = false;
            button5.Visible = false;
            button7.Visible = false;
        }

        private void TeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddStudent addstudent = new AddStudent();
            this.Hide();
            addstudent.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = Teacher.GetStudentsList();
            listBox1.DisplayMember = "DisplayStudentInfo";
            listBox1.Visible = true;
            listBox1.ValueMember = "Id";
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = false;
            button7.Visible = true;

        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                int selectedId = (int)listBox1.SelectedValue;
                Teacher.StudentPresenceStatus(selectedId, true);

                listBox1.DataSource = Teacher.GetStudentsList();
                listBox1.DisplayMember = "DisplayStudentInfo";
                listBox1.ValueMember = "Id";

                listBox1.SelectedValue = selectedId;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                int selectedId = (int)listBox1.SelectedValue;
                Teacher.StudentPresenceStatus(selectedId, false);

                listBox1.DataSource = Teacher.GetStudentsList();
                listBox1.DisplayMember = "DisplayStudentInfo";
                listBox1.ValueMember = "Id";

                listBox1.SelectedValue = selectedId;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedValue != null)
            {
                int selectedId = (int)listBox1.SelectedValue;
                Teacher.DeleteStudent(selectedId);

                listBox1.DataSource = Teacher.GetStudentsList();
                listBox1.DisplayMember = "DisplayStudentInfo";
                listBox1.ValueMember = "Id";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedValue != null)
            {
                int selectedId = (int)listBox1.SelectedValue;
                Edit edit =new Edit();
                edit.ID = selectedId;
                edit.Show();
                this.Hide();
               
            }
        }
    }
}
