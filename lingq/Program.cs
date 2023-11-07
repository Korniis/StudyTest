namespace lingq
{
    class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }
        public int salary { get; set; }
        public override string ToString()
        {
            return $"id={Id},Name={Name},Age={Age},Gender={Gender},salary={salary} ";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Employee employee1 = new Employee() { Id = 123, Name = "asd", Gender = true, salary = 213, Age = 131 };
            Employee employee2 = new Employee() { Id = 122143, Name = "123", Gender = true, salary = 34, Age = 131 };
            Employee employee3 = new Employee() { Id = 112423, Name = "1243", Gender = true, salary = 334, Age = 131 };
            Employee employee4 = new Employee() { Id = 112423, Name = "as421d", Gender = true, salary = 346, Age = 131 };
            
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            var item1 = list.Count(e => e.salary > 100);
            Console.WriteLine(item1);
            var e1 = list.First( e=>e.Id==122143);
            var item2 = list.OrderBy(e => e.Age).OrderByDescending(e=>e.salary);
            Console.WriteLine(e1);
            Console.WriteLine(list.Any(e=>e.Gender==false ));
            foreach (var item in item2)
            {
                Console.WriteLine(item);
            }
            int[] nums = new int[] { 1, 2, 3,2,6,7,42, };
            var num2 = nums.OrderBy(e=>Guid.NewGuid());
            Console.WriteLine(num2.ToString());
            foreach (var item in num2)
            {
                Console.WriteLine(item);
            }
            var item3 = list.OrderBy(e => e.Age).ThenBy(e=>e.salary);
            var item4 = list.Skip(3).Take(2);

            foreach (var item in item4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Where(e=>e.Id>6).Min(e=>e.Age));
            var items1 = list.GroupBy(e => e.salary);

            foreach (var items3 in items1)
            {
                Console.WriteLine(items3.Key);
                foreach (var item in items3)
                {
                    Console.WriteLine(item);
                }

            }
            var ke = list.Where(e=>e.salary>1200).MaxBy(e=>e.Id);
            Console.WriteLine(ke);

        }
    }
}