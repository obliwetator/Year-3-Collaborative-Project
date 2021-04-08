using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using GroupProject.Classes;
using GroupProject.Classes.SerialzationClasses;
using GroupProject.Forms.User;

namespace GroupProject
{
    public partial class CustomerDashboardform : Form
    {
        private UserSaveLoadConfig _config;
        public CustomerDashboardform()
        {
            InitializeComponent();
        }

        private void CustomerDashboardform_Load(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void btnLoadConfig_Click(object sender, EventArgs e)
        {
            UserLoadConfiguration userConfirmCarChoice = new UserLoadConfiguration(clsUser.ID1)
            {
                Location = this.Location,
                Size = new Size(1280, 720),
                // Otherwise we can't put the form where we want
                StartPosition = FormStartPosition.Manual
            };

            userConfirmCarChoice.Show(); 
        }

        private void button_Click (object sender, EventArgs e)
        {
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var UserBrowseVehicles = new UserBrowseVehicles();

            this.Hide();

            UserBrowseVehicles.Show();
        }

        private void btnLoadLocalConfig_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "JSON File (*.json)|*.json",
                Title = "Load your configuration",
            };

            if (ofd.ShowDialog() != DialogResult.OK) return;
            if (ofd.FileName != "")
            {
                // Open the text file using a stream reader.
                var sr = new StreamReader(ofd.FileName);
                
                // Read the stream as a string, then decode that string as our object
                var a = sr.ReadToEnd();
                _config = JsonSerializer.Deserialize<UserSaveLoadConfig>(a);
                
                // Load json
                UserConfirmCarChoice userConfirmCarChoice = new UserConfirmCarChoice(_config.car, _config.userId, _config.comment)
                {
                    Location = this.Location,
                    Size = new Size(1280, 720),
                    // Otherwise we can't put the form where we want
                    StartPosition = FormStartPosition.Manual
                };

                userConfirmCarChoice.Show(); 
            }
        }
    }
}
