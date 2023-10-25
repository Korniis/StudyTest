using System.Text;

namespace 线程切换
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine( Thread.CurrentThread.ManagedThreadId);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("xxxxxx\n" ); 
            }
            await File.WriteAllTextAsync(@"d:\1.txt",sb.ToString());

            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

        }
    }
}