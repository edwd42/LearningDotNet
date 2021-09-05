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

            Console.WriteLine("Customers count = " + customers.Count);

            foreach (var customer in customers)
            {
                Console.WriteLine("customer = " + customer);
            }

            Console.WriteLine("customers[1] = " + customers[1]);

            Dictionary<String, String> config = new Dictionary<string, string>();
            config.Add("resolution", "1920x1080");
            config.Add("title", "MyWebsite");

            Console.WriteLine("config[title] = " + config["title"]);

            foreach (var setting in config)
            {
                Console.WriteLine("setting.Value = " + setting.Value);
            }

            // boxing
            int i = 123;
            object o = i;

            Console.WriteLine("boxed i = " + i);
            Console.WriteLine("boxed o = " + o);

            // unboxing
            i = (int)o;

            Console.WriteLine("unboxed i = " + i);
            Console.WriteLine("unboxed o = " + o);

            // ArrayList is depricated
            ArrayList list = new ArrayList();
            list.Add("some string");
            String s = (String)list[0];

            Console.WriteLine("list[0] = " + list[0]);

            // Hashtables
            Hashtable table = new Hashtable();
            table.Add("title", "My Hashtable");
            var t = (String)table["title"];
            Console.WriteLine("My Hashtable[title] = " + t);

            // Concurrent for thread-safe collections
            Thread thread1 = new Thread(new ThreadStart(AddItem));
            Thread thread2 = new Thread(new ThreadStart(AddItem));

            thread1.Start();
            thread2.Start();

            // BitArray
            bool[] preload = new bool[3] { true, false, true };
            BitArray enemyGrid = new BitArray(preload);
            //enemyGrid[0] = false;
            //enemyGrid[1] = true;
            //enemyGrid.Set(2, false);

            foreach (var item in enemyGrid)
            {
                Console.WriteLine("enemyGrid.item = " + item);
            }

            //Tuple<int, String, bool> myTuple = new Tuple<int, string, bool>(1, "hello myTuple", true);
            var myTuple = Tuple.Create(1, "hello Tuple.Create()", true);
            Console.WriteLine(myTuple.Item2);
        }

        static void AddItem()
        {
            items.TryAdd(1, 2);
            Console.WriteLine("Inside AddItem()");
            Console.WriteLine("items.Count = " + items.Count);
            //Console.WriteLine(items[0]);
            //Console.WriteLine(items[1]);
        }
    }
}
