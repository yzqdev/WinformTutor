namespace SystemOperate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             CpuDetect cpuDetect = new CpuDetect();
            cpuDetect.Show();

        }
    }
}