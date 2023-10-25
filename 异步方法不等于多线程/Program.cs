namespace 异步方法不等于多线程
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            double r= await DecimalAsync(500);
            await Console.Out.WriteLineAsync($"r={r}");
            
        }
        public static async Task<double> DecimalAsync(int n)
        {
            /* Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
             double result = 0;
             Random random = new Random();
             for (int i = 0; i < n * n; i++)
             {

                 result += random.NextDouble();

             }
             return result;*/
            return await Task.Run(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                double result = 0;
                Random random = new Random();
                for (int i = 0; i < n * n; i++)
                {

                    result += random.NextDouble();

                };
                return result;

            });

        }
    }
}