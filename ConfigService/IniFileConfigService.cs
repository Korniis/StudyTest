using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfigService
{
    public class IniFileConfigService : IConfigService
    {
        public string FilePath { get; set; }


        public string GetValue(string name)
        {
            var kv = File.ReadAllLines(FilePath).Select(s => s.Split('=')).Select(str => new { Name = str[0], Value = str[1] })
                   .SingleOrDefault(kv => kv.Name == name);
            if (kv != null)
            {
                return kv.Value;
            }
            else
            {
                return null;
            }
        }
    }
}
