using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {

            var customers = new Customers();

            customers.LoadCustomers();
            customers.PrintCustomers();
        }


        static void Run() { 

            Random rnd = new Random();
            
            List<int> bowl = new List<int>(10);
           
            
                for (int i = 0; i < 10; i++) {
                    bowl.Add(rnd.Next(0, 31));

                }
                int total = 0;
                foreach (var bo in bowl) {
                    total += bo;
                    Console.WriteLine($"{ bo}");

                }
            
            Console.WriteLine($"Game total score {total}");


            //List<string> names = new List<string> { "Greg", "Marianne", "Brailee" };

            //var integers = new List<int>();
            //integers.Add(7);
            //integers.Add(4);
            //integers.Add(13);

            //integers.Remove(4);
            //integers.AddRange(new int[] { 4, 44, 444, 4444 });
            //var w = new int[] { 7, 13, 4, 44, 444, 4444 };
            //integers[3] = 99;

            //foreach(var i in integers) {
            //    Console.WriteLine($" i = {i}");
            //}

        }
    }
}
