namespace HostsChanger
{
    public partial class Form1 : Form
    {
        private static readonly string DOMAIN_LIST = "192.168.0.3 rumiserver.com\n" +
                                            "192.168.0.3 ussr.rumiserver.com\n" +
                                            "192.168.0.3 rumi-room.net\n";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Local_Button_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\windows\system32\drivers\etc\hosts", DOMAIN_LIST);
            MessageBox.Show("Ç†Ç»ÇΩÇÕç°ÅAÇ®â∆Ç…Ç¢Ç‹Ç∑");
        }

        private void Soto_Button_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"C:\windows\system32\drivers\etc\hosts", "");
            MessageBox.Show("Ç†Ç»ÇΩÇÕç°ÅAÇ®äOÇ…Ç¢Ç‹Ç∑");
        }
    }
}
