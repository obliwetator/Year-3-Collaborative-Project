using System.Collections.Generic;
using System.Windows.Forms;

namespace GroupProject
{
	public partial class UserConfirmCarChoice : Form
	{
		private Dictionary<string, bool> _carConfigurationChosen;
		public UserConfirmCarChoice(Dictionary<string, bool> carConfigurationChosen)
		{
			this._carConfigurationChosen = carConfigurationChosen;
			InitializeComponent();
		}
	}
}