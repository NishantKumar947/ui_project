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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sign_Up_Form
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=NISHANT\SQLEXPRESS;Initial Catalog=internal_assessment;Integrated Security=True");



        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Login successful!");
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User name and password fields are empty.");
            }
            String user_id, user_pass;
            user_id = txtusername.Text;
            user_pass = txtpassword.Text;
            try
            {
                String query = "SELECT * FROM user_details WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    user_id = txtusername.Text;
                    user_pass = txtpassword.Text;
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusername.Clear();
                    txtpassword.Clear();
                    txtusername.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Signup_form form = new Signup_form();
            form.ShowDialog();
            this.Hide();
        }

        private void quitbtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void quitbtn_Click_1(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
