using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;
using System;

namespace Chatify.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            //ping 172.16.65.42
            var url = "http://172.16.65.42:8080/";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine($"Server running at {url}");
                Console.ReadLine();
            }
        }
    }
}
