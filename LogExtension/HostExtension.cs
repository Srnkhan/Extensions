using Microsoft.Extensions.Hosting;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogExtension
{
    public static class HostExtension
    {
        public static IHostBuilder MongoUseSerilog(this IHostBuilder hostBuilder) 
        {
            hostBuilder.UseSerilog((context, config) =>
            {
                config.ReadFrom.Configuration(context.Configuration);
            });

            return hostBuilder;
        }
    }
}
