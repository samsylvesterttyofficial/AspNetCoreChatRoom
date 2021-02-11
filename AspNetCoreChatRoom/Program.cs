﻿using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace AspNetCoreChatRoom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Development branch changes - New Line
            // Testing staging
            // Testing No Access Testing by unauthorized
            // Testing sync functionality
            // TEM-37873 functionality
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
