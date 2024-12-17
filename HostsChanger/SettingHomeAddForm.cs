using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsChanger
{
	public partial class SettingHomeAddForm : Form
	{
		public string INPUT_DOMAIN = null;
		public string INPUT_IP = null;

		public SettingHomeAddForm(string DOMAIN, string IP)
		{
			INPUT_DOMAIN = DOMAIN;
			INPUT_IP = IP;

			InitializeComponent();
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			INPUT_DOMAIN = DomainTextBox.Text;
			INPUT_IP = IP_TextBox.Text;

			this.Close();
		}

		private void Jametabutton_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SettingHomeAddForm_Load(object sender, EventArgs e)
		{
			DomainTextBox.Text = INPUT_DOMAIN;
			IP_TextBox.Text = INPUT_IP;
		}
	}
}
