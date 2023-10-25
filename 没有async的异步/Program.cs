namespace 没有async的异步
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            string s = await ReadAsync(1);
            Console.WriteLine(s);
        }
        /*  public static async Task<string> ReadAsync(int num)
          {
              if (num == 1)
              {
                  return await File.ReadAllTextAsync(@"d:\ddd.txt");
              }
              else if (num == 2)
              {
                  return await File.ReadAllTextAsync(@"d:\2.txt");
              }
              else
              {
                  throw new ArgumentException()
                  {
                  };
              }*/
        static Task<string> ReadAsync(int num)
        {
            if (num == 1)
            {
                return File.ReadAllTextAsync(@"d:\ddd.txt");
            }
            else if (num == 2)
            {
                return File.ReadAllTextAsync(@"d:\2.txt");
            }
            else
            {
                throw new ArgumentException()
                {
                };
            }
        }
    }
}