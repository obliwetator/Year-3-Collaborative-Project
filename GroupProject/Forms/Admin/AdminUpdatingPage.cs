using System.Windows.Forms;

namespace GroupProject.Forms.Admin
{
    public partial class AdminUpdatingPage : Form
    {
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
