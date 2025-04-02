namespace CS322_Projekat.Forms
{
    partial class AdminDashboardForm
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
            components = new System.ComponentModel.Container();
            btnLogout = new Button();
            tabAdmin = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            btnCreate = new Button();
            dgvArtists = new DataGridView();
            artistBindingSource = new BindingSource(components);
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabAdmin.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvArtists).BeginInit();
            ((System.ComponentModel.ISupportInitialize)artistBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(667, 395);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tabAdmin
            // 
            tabAdmin.Controls.Add(tabPage1);
            tabAdmin.Controls.Add(tabPage2);
            tabAdmin.Controls.Add(tabPage3);
            tabAdmin.Controls.Add(tabPage4);
            tabAdmin.Location = new Point(72, 39);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.SelectedIndex = 0;
            tabAdmin.Size = new Size(640, 350);
            tabAdmin.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(632, 317);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Vinyls";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnCreate);
            tabPage2.Controls.Add(dgvArtists);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(632, 317);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Artists";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(270, 256);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // dgvArtists
            // 
            dgvArtists.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvArtists.Location = new Point(45, 31);
            dgvArtists.Name = "dgvArtists";
            dgvArtists.ReadOnly = true;
            dgvArtists.RowHeadersWidth = 51;
            dgvArtists.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvArtists.Size = new Size(564, 185);
            dgvArtists.TabIndex = 0;
            dgvArtists.CellContentClick += dgvArtists_CellContentClick;
            // 
            // artistBindingSource
            // 
            artistBindingSource.DataSource = typeof(Models.Artist);
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(632, 317);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Users";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(632, 317);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Sales";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabAdmin);
            Controls.Add(btnLogout);
            Name = "AdminDashboardForm";
            Text = "AdminDashboard";
            tabAdmin.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvArtists).EndInit();
            ((System.ComponentModel.ISupportInitialize)artistBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private TabControl tabAdmin;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dgvArtists;
        private BindingSource artistBindingSource;
        private Button btnCreate;
    }
}