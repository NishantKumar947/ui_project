using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sign_Up_Form
{
    public partial class Signup_form : Form
    {
        public Signup_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NISHANT\SQLEXPRESS;Initial Catalog=internal_assessment;Integrated Security=True");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || txtconpass.Text == "")
            {
                MessageBox.Show("username and password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtpassword.Text == txtconpass.Text)
            {

                conn.Open();
                string insertQuery = "INSERT INTO user_details (username, password) VALUES (@username, @password)";

                using (SqlCommand command = new SqlCommand(insertQuery, conn))
                {

                    command.Parameters.AddWithValue("@username", txtusername.Text);
                    command.Parameters.AddWithValue("@password", txtpassword.Text);

                    command.ExecuteNonQuery();


                }
                conn.Close();
                txtusername.Clear();
                txtpassword.Clear();
                txtconpass.Clear();
                txtusername.Focus();
                MessageBox.Show("Your account has been successfully created", "Signup successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwords doesn't match, please re-enter", "Signup failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Clear();
                txtconpass.Clear();
                txtpassword.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
            txtconpass.Text = "";
            txtusername.Focus();
        }

        private void checkboxshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxshowpass.Checked)
            {
                txtpassword.PasswordChar = '\0';
                txtconpass.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
                txtconpass.PasswordChar = '*';
            }
        }
        private void label6_Click(object sender, EventArgs e)
        {
            Login_Form Form = new Login_Form();
            Form.ShowDialog();
            this.Hide();

        }

        private void Signup_form_Load(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
