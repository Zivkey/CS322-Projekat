namespace CS322_Projekat.Forms
{
    partial class ArtistForm
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
            btnBack = new Button();
            lblName = new Label();
            lblDescription = new Label();
            txtName = new TextBox();
            btnSave = new Button();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            lblTitle = new Label();
            txtDescription = new TextBox();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(310, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(174, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(174, 166);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // txtName
            // 
            txtName.Location = new Point(174, 120);
            txtName.Name = "txtName";
            txtName.Size = new Size(363, 27);
            txtName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(310, 374);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Create";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(334, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(55, 20);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "ARTIST";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(174, 206);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(363, 112);
            txtDescription.TabIndex = 6;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(310, 331);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(0, 20);
            lblMessage.TabIndex = 7;
            // 
            // ArtistForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(txtDescription);
            Controls.Add(lblTitle);
            Controls.Add(btnSave);
            Controls.Add(txtName);
            Controls.Add(lblDescription);
            Controls.Add(lblName);
            Controls.Add(btnBack);
            Name = "ArtistForm";
            Text = "ArtistForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblName;
        private Label lblDescription;
        private TextBox txtName;
        private Button btnSave;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private Label lblTitle;
        private TextBox txtDescription;
        private Label lblMessage;
    }
}