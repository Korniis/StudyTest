using ConfigService;
using LogService;
using MailService;
using Microsoft.Extensions.DependencyInjection;
namespace ConsoleAppMail
  
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceCollection services = new ServiceCollection();
            services.AddScoped<IConfigService, EnvConfigSevice>();
            services.AddScoped<IMailService, MailServices>();
            services.AddScoped<ILogProvider, ConsoleLogProvider>();
            using (var sp = services.BuildServiceProvider())
            {
                var mailService = sp.GetRequiredService<IMailService>();
                mailService.send("hello", "asd", "asda");


            }
        }
    }
}