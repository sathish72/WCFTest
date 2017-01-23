using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace MicroServices
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://127.0.0.3";

            using(WebApp.Start<Startup>(url:baseAddress))
            {
                Console.WriteLine("Service Listing at " + baseAddress);
                System.Threading.Thread.Sleep(-1);
            }
        }
    }
}
