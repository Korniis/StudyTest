namespace yibbuweituo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(async(obj) =>
            {

                while (true)
                {

                    await File.WriteAllTextAsync(@"D:\ddd.txt", "sadasdasdasd");
                    Console.WriteLine("ssssss");

                   
                }

            });
            Console.Read();

        }
    }
}