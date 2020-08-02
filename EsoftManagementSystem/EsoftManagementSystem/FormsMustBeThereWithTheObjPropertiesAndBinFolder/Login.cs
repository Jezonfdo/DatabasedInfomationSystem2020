using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsoftManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var un = textBoxUsername.Text;
            var pw = textBoxPassword.Text;

            if (un == "Admin" && pw == "1234")
            {
                MessageBox.Show("Login as Admin");

                //main menu
                MainMenu obj = new MainMenu();
                obj.Show();
                this.Hide();
            }
            else if (un == "Receptionist" && pw == "1234")
            {
                MessageBox.Show("Login as Receptionist Aunty");

                //main menu
                MainMenu nh = new MainMenu();
                nh.Show();
                this.Hide();
            }
            else if (un == "Kithsara" && pw == "1234")
            {
                MessageBox.Show("Login as Teacher1");

                //main menu
                MainMenu nh = new MainMenu();
                nh.Show();
                this.Hide();

            }
            else if (un == "Praveen" && pw == "1234")
            {
                MessageBox.Show("Login as Teacher2");

                //main menu
                MainMenu nh = new MainMenu();
                nh.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            
                if (checkBoxShowPassword.Checked)
                {
                    textBoxPassword.UseSystemPasswordChar = false;

                }
                else
                {
                    textBoxPassword.UseSystemPasswordChar = true;
                }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.WindowState = FormWindowState.Minimized;
        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
