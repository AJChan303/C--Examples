using System;

namespace InterfacewithMike {
    class Program {
        static void Main(string[] args) {
            var p1 = new Partner();
            p1.Id = 123;
            p1.CreditLimit = 1000m;

            var x = (IVendor)p1;
            var y = (Partner)x;
            PrintLabel(p1);
            var c1 = new Customer();
            PrintLabel(c1);

            var p2 = new Partner();
            p2.Id = 456;
            p2.CreditLimit = 5000m;

            if (p1.CompareTo(p2) > 0) {
                Console.WriteLine("P1 is better");
            } else {
                Console.WriteLine("p1 is not better");
            }
        }
        static void PrintLabel(IPrintLabel theAddressObject) {
            Console.WriteLine(theAddressObject.Name + " " + theAddressObject.Address);
        }
    }

    interface IVendor {
        int Id { get; set; }
        string Name { get; set; }

        decimal CreditLimit { get; set; }

        void YellAtVendor(string msg);
        string Purchase(string Item, int Qty);

        //events
    }
    interface IPrintLabel {
        string Name { get; set; }
        string Address { get; set; }
        
    }
    class Customer: IPrintLabel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }

    class Partner : IVendor, IComparable, IPrintLabel {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public decimal CreditLimit { get; set; }// would need code to actually get it

        public int CompareTo(object obj) {
            //boxing and unboxing
            Partner theOtherGuy = (Partner) obj;
            if(this.CreditLimit == theOtherGuy.CreditLimit) {
                return 0;
            } else if( this.CreditLimit > theOtherGuy.CreditLimit) {
                return 1;
            } else { return -1; }
            throw new NotImplementedException();
        }

        public string Purchase(string Item, int Qty) {
            //
            return "Purchased";
        }

        public void YellAtVendor(string msg) {
            Console.WriteLine(msg);
        }
    }
    class BankAccount {
        public int fred;
    }
}
