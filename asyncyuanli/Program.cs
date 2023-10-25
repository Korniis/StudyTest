namespace asyncyuanli
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string html = await httpClient.GetStringAsync("https://tieba.baidu.com/");

                Console.WriteLine(html);
            }
          
            string txt = "hello yzk";
            string filename = @"D:\1.txt";
            await File.WriteAllTextAsync(filename, txt);
            Console.WriteLine("done");
    
            string s = await File.ReadAllTextAsync(filename);
            Console.WriteLine("wemja" + s);
        }
    }
}