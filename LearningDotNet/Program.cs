using System;
using System.Collections.Generic;

namespace LearningDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> customers = new List<String>();

            customers.Add("Me");
            customers.Add("You");
            customers.Add("Them");

            Console.WriteLine(customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine(customers[1]);

            Dictionary<String, String> config = new Dictionary<string, string>();
            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine(config["title"]);

            foreach (var setting in config)
            {
                Console.WriteLine(setting.Value);
            }
        }
    }
}
