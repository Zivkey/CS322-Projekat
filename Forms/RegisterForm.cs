using CS322_Projekat.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_Projekat
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string confirmPassword = txtPasswordConfirm.Text.Trim();

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(name) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                lblMessage.Text = "You need to insert all the fields!";
                return;
            }

            if (password != confirmPassword)
            {
                lblMessage.Text = "Passwords do not match!";
                return;
            }

            var userService = new UserService();
            bool success = userService.RegisterUser(name, email, password);

            if (!success)
            {
                lblMessage.Text = "User with that email already exist!";
                return;
            }

            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = "Registration successfull!";

            Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    var loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }));
            });

        }
    }
}
