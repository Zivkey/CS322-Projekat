using CS322_Projekat.Dto;
using CS322_Projekat.Models;
using CS322_Projekat.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_Projekat.Forms
{
    public partial class AdminDashboardForm : Form
    {

        private readonly ArtistService _artistService = new ArtistService();

        public AdminDashboardForm()
        {
            InitializeComponent();

            this.Load += new EventHandler(AdminDashboardForm_Load);

        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadArtists();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new ArtistForm(null);
            form.ShowDialog();
        }

        private void LoadArtists()
        {
            dgvArtists.Columns.Clear(); // Resetuj kolone

            var artists = _artistService.GetAll()
                .Select(a => new ArtistDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Description = a.Description
                })
                .ToList();

            dgvArtists.DataSource = artists;

            // ✏️ Edit dugme
            DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn();
            editBtn.Name = "EditColumn";
            editBtn.HeaderText = "Edit";
            editBtn.Text = "✏️";
            editBtn.UseColumnTextForButtonValue = true;
            editBtn.Width = 50;
            dgvArtists.Columns.Add(editBtn);

            // 🗑️ Delete dugme
            DataGridViewButtonColumn deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Name = "DeleteColumn";
            deleteBtn.HeaderText = "Delete";
            deleteBtn.Text = "🗑️";
            deleteBtn.UseColumnTextForButtonValue = true;
            deleteBtn.Width = 50;
            dgvArtists.Columns.Add(deleteBtn);

            if (dgvArtists.Columns["Id"] != null)
            {
                dgvArtists.Columns["Id"].Visible = false;
            }

            dgvArtists.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var clickedColumn = dgvArtists.Columns[e.ColumnIndex];
            string columnName = dgvArtists.Columns[e.ColumnIndex].Name;

                var cell = dgvArtists.Rows[e.RowIndex].Cells["Id"];
                if (cell == null || cell.Value == null)
                {
                    return;
                }

                int artistId = (int)cell.Value;

                var artist = _artistService.GetAll().FirstOrDefault(a => a.Id == artistId);
                if (artist == null)
                {
                    return;
                }


                if (columnName == "EditColumn")
                {

                    var form = new ArtistForm(artist);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadArtists();
                    }
                }
                else if (columnName == "DeleteColumn")
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this artist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        _artistService.Delete(artist.Id);
                        LoadArtists();
                    }
                }
        }


    }
}
