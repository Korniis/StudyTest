namespace yibuxiuxi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient httpClient = new HttpClient())
            {
               string s1= await httpClient.GetStringAsync("https://tieba.baidu.com/f?kw=%E7%A2%A7%E8%93%9D%E8%88%AA%E7%BA%BF&fr=index");
                textBox1.Text =s1.Substring(0,20) ;
              await Task.Delay(2000) ;
                string s2 = await httpClient.GetStringAsync("https://tieba.baidu.com/f?kw=%E7%A2%A7%E8%93%9D%E8%88%AA%E7%BA%BF&fr=index");
                textBox1.Text+=s2.Substring(0,20) ;
            }
        }

      
    }
}