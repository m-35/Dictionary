using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> customer = new Dictionary<int, string>();
            customer.Add(1,"Miray KOZLU");
            customer.Add(2,"Seda AKÇA");
            customer.Add(3, "Esra KETE");
            customer.Add(4, "Hasan BİLGE");
            customer.Add(5, "KAAN TİRE");
            customer.Add(6, "Ayşe TATLICI");

            foreach (var customerNumber in customer.Keys)
            {
                Console.WriteLine(customerNumber);
            }
            foreach (var customerName in customer.Values)
            {
                Console.WriteLine(customerName);
            }
        }
    }
}
