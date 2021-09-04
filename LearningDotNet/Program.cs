using System;
using System.Collections;
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

            // boxing
            int i = 123;
            object o = i;

            Console.WriteLine(i);
            Console.WriteLine(o);

            // unboxing
            i = (int)o;

            Console.WriteLine(i);
            Console.WriteLine(o);

            ArrayList list = new ArrayList();
            list.Add("some string");
            String s = (String)list[0];
        }
    }
}
