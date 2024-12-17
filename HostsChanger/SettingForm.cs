using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostsChanger
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			//全消し
			HomeHostsContentsListView.Items.Clear();

			//fileロード
			string FILE_DATA = File.ReadAllText(ConstVar.HOME_HOSTS_CONFIG_PATH);
			foreach (string LINE in FILE_DATA.Split("\n"))
			{
				//ぬるぽ防止
				if (LINE.Split("\t").Length == 2)
				{
					string DOMAIN = LINE.Split("\t")[0];
					string IP = LINE.Split("\t")[1];
					ListViewItem ITEM = new ListViewItem();
					ITEM.Text = DOMAIN;
					ITEM.SubItems.Add(IP);
					HomeHostsContentsListView.Items.Add(ITEM);
				}
			}
		}

		//家のhostsを追加
		private void home_add_button_Click(object sender, EventArgs e)
		{
			SettingHomeAddForm FORM = new SettingHomeAddForm("", "");
			FORM.ShowDialog(this);

			if (FORM.INPUT_DOMAIN != null && FORM.INPUT_IP != null)
			{
				ListViewItem ITEM = new ListViewItem();
				ITEM.Text = FORM.INPUT_DOMAIN;
				ITEM.SubItems.Add(FORM.INPUT_IP);
				HomeHostsContentsListView.Items.Add(ITEM);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string home_txt_CONTENTS = "";
			foreach (ListViewItem ITEM in HomeHostsContentsListView.Items)
			{
				home_txt_CONTENTS += ITEM.Text + "\t" + ITEM.SubItems[1].Text + "\n";   //←なぜか0ではなく1らしい
			}
			File.WriteAllText(ConstVar.HOME_HOSTS_CONFIG_PATH, home_txt_CONTENTS);

			//再起動
			Application.Restart();
		}

		private void HomeHostsContentsListView_DoubleClick(object sender, EventArgs e)
		{
			SettingHomeAddForm FORM = new SettingHomeAddForm(HomeHostsContentsListView.SelectedItems[0].Text, HomeHostsContentsListView.SelectedItems[0].SubItems[1].Text);
			FORM.ShowDialog(this);

			if (FORM.INPUT_DOMAIN != null && FORM.INPUT_IP != null)
			{
				HomeHostsContentsListView.SelectedItems[0].Text = FORM.INPUT_DOMAIN;
				HomeHostsContentsListView.SelectedItems[0].SubItems[1].Text = FORM.INPUT_IP;
			}
		}
	}
}
