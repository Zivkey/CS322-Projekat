using CS322_Projekat.Enums;
using CS322_Projekat.Forms;
using CS322_Projekat.Models;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Email and password are required!";
                return;
            }

            var userService = new UserService();
            User user = userService.LoginUser(email, password);

            if (user == null)
            {
                lblMessage.Text = "Wrong email or password!";
                return;
            }

            Task.Delay(0).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    Form dashboard;

                    if (user.Role == RoleEnum.Admin)
                        dashboard = new AdminDashboardForm();
                    else
                        dashboard = new UserDashboardForm(user); // ako korisniku želiš da proslediš podatke

                    dashboard.Show();
                    this.Hide();
                }));
            });

        }
    }
}
