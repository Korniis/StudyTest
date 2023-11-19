using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConfigService;
using LogService;

namespace MailService
{
    public class MailServices : IMailService
    {
        private readonly ILogProvider logProvider;
        private readonly IConfigService config;
        public MailServices(ILogProvider logProvider, IConfigService config)
        { 
        this.logProvider = logProvider;
            this.config = config;
        }
        public void send(string title, string to, string body)
        {
            this.logProvider.LogInfo("start");
          string smt=  this.config.GetValue("smt");
          string smtName=  this.config.GetValue("user");
          string smtPass=  this.config.GetValue("pass");
            Console.WriteLine(smtPass+smtName+ smt);
            Console.WriteLine($"{title}{to}");
            this.logProvider.LogInfo("end");
        }
    }
}
