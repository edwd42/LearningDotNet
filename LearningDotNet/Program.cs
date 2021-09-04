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
        }
    }
}
