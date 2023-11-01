namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = File.ReadAllText(@"D:\ddd.txt");
            MessageBox.Show(s);
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            string s = await File.ReadAllTextAsync(@"D:\ddd.txt");
            MessageBox.Show(s);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}