using Microsoft.Extensions.DependencyInjection;
namespace IOC
{
    public class TestServiceImpl2 : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"你好，我是{Name}");
        }
    }
    public interface ITestService
    {
        public string Name { get; set; }
        public void SayHi();
    }
    public class TestServiceImpl : ITestService
    {
        public string Name { get; set; }
        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<TestServiceImpl>();
            using (var service = services.BuildServiceProvider())
            {
                TestServiceImpl service3 = service.GetService<TestServiceImpl>();
                /*
                                TestServiceImpl service2 =  service.GetService<TestServiceImpl>();
                                service2.SayHi();*/
                using (var scope = service.CreateScope())
                {
                    TestServiceImpl service2 = scope.ServiceProvider.GetService<TestServiceImpl>();
                    service2.Name = "qwe";
                    service2.SayHi();
                    TestServiceImpl service1 = scope.ServiceProvider.GetService<TestServiceImpl>();
                    service1.Name = "asdas";
                    service1.SayHi();
                    service2.SayHi();
                    Console.WriteLine(object.ReferenceEquals(service1, service2));
                    Console.WriteLine(object.ReferenceEquals(service3, service2));
                }
            }
        }
    }
}