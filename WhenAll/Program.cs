namespace WhenAll
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            /*   Task<string> t1 = File.ReadAllTextAsync(@"D:\ddd1.txt");
               Task<string> t2 = File.ReadAllTextAsync(@"D:\ddd2.txt");
               Task<string> t3 = File.ReadAllTextAsync(@"D:\ddd3.txt");
               string[] strs = await Task.WhenAll(t1, t2, t3);
               string s1 = strs[0];
               string s2 = strs[1];
               string s3 = strs[2];
               await Console.Out.WriteLineAsync(s1);
               await Console.Out.WriteLineAsync(s2);
               await Console.Out.WriteLineAsync(s3);*/
            string[] files = Directory.GetFiles(@"D:\ds");
            Task<int>[] counts = new Task<int>[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                string filename = files[i];
                Task<int> t =  ReadCharsCount(filename);
                await Console.Out.WriteLineAsync(filename);
                counts[i] = t;
            }
            int[]count= await Task.WhenAll(counts);
            int c = count.Sum();
          Console.WriteLine(c);
        }
       static  async Task<int> ReadCharsCount(string filename)
        {
            string s = await File.ReadAllTextAsync(filename);
            return s.Length;
        }
    }
}