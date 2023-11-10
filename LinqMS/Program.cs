namespace LinqMS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    string s = "53,33,55,888,9";
                string[] strs = s.Split(',');
                var nums = strs.Select(e => Convert.ToInt32(e)).Average();

                Console.WriteLine(nums);*/
            string s = "asdasdasdasdasdasdas123123sdasdDSAFG a FDADSFSAdASDF SADF SAdf";
          var items= s.Where(c => char.IsLetter(c))
                .Select(c => char.ToLower(c))
                .GroupBy(c => c)
                .Select(g => new { g.Key,Count=g.Count() })
                .Where(g => g.Count > 2) 
                .OrderByDescending(g =>g.Count)
               ;
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }



        }
    }
}