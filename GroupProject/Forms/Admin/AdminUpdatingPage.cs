using System.Windows.Forms;
using MySql.Data.Common;
using MySql.Data;
using GroupProject.Classes;

namespace GroupProject.Forms.Admin
{
    public partial class AdminUpdatingPage : Form
    {
        private const string conString = "server=plesk.remote.ac;user=ws330584_dealership;database=ws330584_dealership;password=Password123;CharSet=UTF8;";
        public AdminUpdatingPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
            AdminDashboard f3 = new AdminDashboard();
            f3.Show();
        }
    }
}
