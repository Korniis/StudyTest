using LogService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConsoleLogExtentions
    { public static void AddConsoleLog(this IServiceCollection services)
        { 
        services.AddScoped<ILogProvider , ConsoleLogProvider>();
        }
    }
}
