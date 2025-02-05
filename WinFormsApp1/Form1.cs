namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            int formWidth = this.Width;
            int formHeight = this.Height;

            this.Location = new Point((screenWidth - formWidth) / 2, (screenHeight - formHeight) / 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (Teacher.IsTeacherValid(username, password))
            {
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                string username = textBox1.Text;
                string password = textBox2.Text;
                if (Teacher.IsTeacherValid(username, password))
                {
                    TeacherForm teacherForm = new TeacherForm();
                    teacherForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

            }
        }
    }
}

