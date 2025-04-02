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

namespace CS322_Projekat.Forms
{
    public partial class ArtistForm : Form
    {
        private readonly Artist? _artistToEdit;

        public ArtistForm(Artist? artist = null)
        {
            InitializeComponent();
            _artistToEdit = artist;

            if (_artistToEdit == null)
            {
                btnSave.Text = "Create";
                txtName.Text = "";
                txtDescription.Text = "";
            }
            else
            {
                btnSave.Text = "Update";
                txtName.Text = _artistToEdit.Name;
                txtDescription.Text = _artistToEdit.Description;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();

            lblMessage.Text = "";
            lblMessage.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(name))
            {
                lblMessage.Text = "Artist name can't be blank!";
                return;
            }

            var artistService = new ArtistService();

            if (_artistToEdit == null)
            {
                var newArtist = new Artist
                {
                    Name = name,
                    Description = description
                };

                artistService.Add(newArtist); 
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Artist added successfully!.";
            }
            else
            {
                _artistToEdit.Name = name;
                _artistToEdit.Description = description;

                artistService.Update(_artistToEdit);
                lblMessage.ForeColor = Color.Green;
                lblMessage.Text = "Artist updated successfully!";
            }

            Task.Delay(1000).ContinueWith(_ =>
            {
                this.Invoke((MethodInvoker)(() =>
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }));
            });
        }

    }
}
