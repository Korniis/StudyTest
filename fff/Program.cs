namespace fff
{
    internal class Program
    {
        static void Main(string[] args)
        {  Task<string> t = File.ReadAllTextAsync(@"D:\ddd.txt");
            string s = t.Result;
            Console.WriteLine(s);
        }
    }
}