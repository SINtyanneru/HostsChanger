namespace HostsChanger
{
	public partial class Form1 : Form
	{
		private static string DOMAIN_LIST = "";

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//�t�@�C�����Ȃ���΍��
			if (!File.Exists(ConstVar.HOME_HOSTS_CONFIG_PATH))
			{
				Directory.CreateDirectory(ConstVar.PROGRAM_DATA_PATH);
				File.CreateText(ConstVar.HOME_HOSTS_CONFIG_PATH);
			}

			//file���[�h
			string FILE_DATA = File.ReadAllText(ConstVar.HOME_HOSTS_CONFIG_PATH);
			foreach (string LINE in FILE_DATA.Split("\n"))
			{
				//�ʂ�ۖh�~
				if (LINE.Split("\t").Length == 2)
				{
					string DOMAIN = LINE.Split("\t")[0];
					string IP = LINE.Split("\t")[1];

					DOMAIN_LIST += IP + " " + DOMAIN + "\n";
				}
			}
		}

		private void Local_Button_Click(object sender, EventArgs e)
		{
			File.WriteAllText(ConstVar.HOSTS_PATH, DOMAIN_LIST);
			MessageBox.Show("���Ȃ��͍��A���Ƃɂ��܂�");
		}

		private void Soto_Button_Click(object sender, EventArgs e)
		{
			File.WriteAllText(ConstVar.HOSTS_PATH, "");
			MessageBox.Show("���Ȃ��͍��A���O�ɂ��܂�");
		}

		private void setting_button_Click(object sender, EventArgs e)
		{
			SettingForm FORM = new SettingForm();
			FORM.ShowDialog(this);
		}
	}
}
