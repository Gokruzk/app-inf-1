namespace WinAppNextHour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime obj = new DateTime();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LblNextH.Text = obj.AddSeconds(1).ToString("HH:mm:ss");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = DateTime.Now;
            LblHour.Text = obj.ToString("HH:mm:ss");
        }
    }
}