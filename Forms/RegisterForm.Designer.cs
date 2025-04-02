namespace CS322_Projekat
{
    partial class RegisterForm
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
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtPasswordConfirm = new TextBox();
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblPasswordConfirm = new Label();
            lblTitle = new Label();
            btnRegister = new Button();
            btnBackToLogin = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(171, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(421, 27);
            txtName.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 134);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(418, 27);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 190);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(418, 27);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtPasswordConfirm
            // 
            txtPasswordConfirm.Location = new Point(174, 252);
            txtPasswordConfirm.Name = "txtPasswordConfirm";
            txtPasswordConfirm.Size = new Size(418, 27);
            txtPasswordConfirm.TabIndex = 3;
            txtPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(171, 49);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 4;
            lblName.Text = "Name";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(174, 111);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(174, 167);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password";
            // 
            // lblPasswordConfirm
            // 
            lblPasswordConfirm.AutoSize = true;
            lblPasswordConfirm.Location = new Point(174, 229);
            lblPasswordConfirm.Name = "lblPasswordConfirm";
            lblPasswordConfirm.Size = new Size(127, 20);
            lblPasswordConfirm.TabIndex = 7;
            lblPasswordConfirm.Text = "Confirm Password";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(324, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(113, 20);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "REGISTER HERE";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(324, 341);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(142, 29);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBackToLogin
            // 
            btnBackToLogin.Location = new Point(324, 388);
            btnBackToLogin.Name = "btnBackToLogin";
            btnBackToLogin.Size = new Size(142, 29);
            btnBackToLogin.TabIndex = 10;
            btnBackToLogin.Text = "Back to Login";
            btnBackToLogin.UseVisualStyleBackColor = true;
            btnBackToLogin.Click += btnBackToLogin_Click;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(339, 295);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 11;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(btnBackToLogin);
            Controls.Add(btnRegister);
            Controls.Add(lblTitle);
            Controls.Add(lblPasswordConfirm);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(txtPasswordConfirm);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtPasswordConfirm;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblPasswordConfirm;
        private Label lblTitle;
        private Button btnRegister;
        private Button btnBackToLogin;
        private Label lblMessage;
    }
}