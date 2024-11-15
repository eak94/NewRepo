namespace View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            butt1.Click += butt1_Click;
            button2.Click += button2_Click;

        }

        private void butt1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Меня зовут Женя");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}