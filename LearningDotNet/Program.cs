using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace LearningDotNet
{
    class Program
    {
        static ConcurrentDictionary<int, int> items = new ConcurrentDictionary<int, int>();
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

            // ArrayList is depricated
            ArrayList list = new ArrayList();
            list.Add("some string");
            String s = (String)list[0];

            Console.WriteLine(list[0]);

            // Hashtables
            Hashtable table = new Hashtable();
            table.Add("title", "My Hashtable");
            var t = (String)table["title"];
            Console.WriteLine(t);

            // Concurrent for thread-safe collections
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();
        }

        static void AddItem()
        {
            items.TryAdd(1, 2);
            Console.WriteLine(items.Count);
            //Console.WriteLine(items[0]);
            //Console.WriteLine(items[1]);
        }
    }
}
