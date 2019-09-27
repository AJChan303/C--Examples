using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections {

    public class Customers {
        List<Customer> customerlist = new List<Customer>();
        public void LoadCustomers() {
            var cust1 = new Customer { Name = "P&G", State = "OH" };
            var cust2 = new Customer { Name = "Microsoft", State = "KY" };
            var cust3 = new Customer { Name = "Target", State = "XY"};
            customerlist.Add(cust1);
            customerlist.Add(cust2);
            customerlist.Add(cust3);
        }
        public void PrintCustomers() {
            foreach (var cust in customerlist) {
                Console.WriteLine($"Customer name: {cust.Name} in state { cust.State}");
            }
        }
        public class Customer {
            public string Name;
            public string State;
        }
    }
}
