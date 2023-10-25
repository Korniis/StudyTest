
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StudyTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
           int i = await DonwloadHtmlAsync("https://battlelog.battlefield.com/bf4/zh/", @"D:\ddd.txt");
            await Console.Out.WriteLineAsync("ok"+i);

        }
        static async Task<int> DonwloadHtmlAsync(string url, string filename)
        {
            using (HttpClient client = new HttpClient())
            {
                string html = await client.GetStringAsync(url);
                await File.WriteAllTextAsync(filename, html);
                return html.Length;
            }
           
        }
    }
}