namespace anyoDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action f1 = delegate ()
            {
                Console.WriteLine("asdasd");

            };
            f1();
            Action<string, int> f2 = delegate (string n, int k)
            {
                Console.WriteLine(n + k);
            };
            f2("asd", 23);
            Func<int, int, int> f3 = (k, d) =>
            {
                return d + k;
            };

            Console.WriteLine(f3(2, 5));
            Func<int, int> f5 = k => k + 3;
            Console.WriteLine(f5(2));

        }
    }
}