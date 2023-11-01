namespace deflagrated
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* int i = 5;*/
            Console.WriteLine(5);
            D1 d1 = F1;
            F1();
            D2 d2;
            d2 = F3;
            d2(2,4);
            Action a = F1;
            a();
            Func<int ,int,int> func = F3;
            func(1, 2);
        }
        static void F1()
        {
            Console.WriteLine("wqe");
        }
        static void F2()
        {
            Console.WriteLine("wqe");
        }
        static int F3(int a ,int b )
        {
            Console.WriteLine("wqe");
            return a+ b;
        }
    }
    delegate void D1();
    delegate int D2(int a,int b);
}