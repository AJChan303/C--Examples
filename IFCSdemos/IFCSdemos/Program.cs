using System;
using System.Collections.Generic;

namespace IFCSdemos {
    class Program {
        static void Main(string[] args) {
            var states = new Dictionary<string, string>();
            states.Add("IN", "Indiana");
            states.Add("OH", "Ohio");
            states.Add("KY", "Kentucky");
            states.Add("PA", "Pennsylvania");
           while(true){ Console.WriteLine("Enter the State Code for, OH, KY, IN, or PA");
            var read = Console.ReadLine();
            if (read == "OH") {
                Console.WriteLine(states["OH"]);
            }else if (read == "KY") {
                Console.WriteLine(states["KY"]);
            }else if (read == "PA") {
                Console.WriteLine(states["PA"]);
            }else if (read == "IN") {
                    Console.WriteLine(states["IN"]);
                }else
                { Console.WriteLine("No state applicable"); }
            else
            }
        }
    }
}
