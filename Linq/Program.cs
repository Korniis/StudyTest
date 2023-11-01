namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] k = { 1, 2, 3,123,1245125,51245123,442,52 };
            var v = MyWhere2(k,a=>a>1254);
            foreach (int i in v)
            {
                Console.WriteLine(i);
            }
        }
       

        static IEnumerable<int> MyWhere1(IEnumerable<int>items, Func<int, bool> f )
        {
            List<int> result =  new List<int>();
            foreach (int item in items)
            {  if(f(item)==true)
                result.Add(item);
            }
            return result;
        
        }
        static IEnumerable<int> MyWhere2(IEnumerable<int> items, Func<int, bool> f)
        {
            foreach (int item in items)
            {
                if (f(item) == true)
                    yield return item;
            }
        }

    }
}