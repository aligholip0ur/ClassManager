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
    public partial class Edit : Form
    {
        public int ID;
        public Edit()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string fname = textBox1.Text;
            string lname = textBox2.Text;
            Teacher.Edit(ID, fname, lname);
        }

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm form = new TeacherForm();
            form.ShowDialog();
            this.Hide();
        }
    }
}
