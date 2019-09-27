using System;

namespace BreakExampls {
    class Program {
        static void Main(string[] args) {
            Customer[] customers = {
                new Customer{Name = "PG", State = "OH" },
                new Customer{ Name = "SDCust", State ="SD" },
                new Customer{Name ="MTCust", State = "MT" }
            };
            bool FoundSDCust = false;
            bool FoundMTCust = false;
            foreach (Customer cust in customers) {
                switch(cust.State) {
                    case "MT":
                        FoundMTCust = true;
                        break;
                    case "SD":
                        FoundSDCust = true;
                        break;
                }
               // if(cust.State == "MT") {
               //     FoundMTCust = true;
               //     continue;
               // }
               
               // if (cust.State == "SD") {
               //     FoundSDCust = true;
               //     continue;

               //}
               // if(FoundMTCust && FoundSDCust) {
               //     break;
               //}
            }
            Console.WriteLine($"found MT Customer:{FoundMTCust}");
            Console.WriteLine($"found SD Customer:{FoundSDCust}");
        }
    }
    class Customer {
        public string Name { get; set; }
        public string State { get; set; }

    }
    
}
