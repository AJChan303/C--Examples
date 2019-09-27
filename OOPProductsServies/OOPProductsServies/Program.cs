using System;

namespace OOPProductsServices {
    class Program {
        static void Main(string[] args) {
            Sales b_widget = new Sales("Basic Widget", 10, 2500);
            Sales a_widget = new Sales("Advanced Widget", 25, 1500);
            Sales s_widget = new Sales("Supreme Widget", 50, 1000);
            Sales b_services = new Sales("Basic Support", 25, 1000);
            Sales a_services = new Sales("Priority Support", 50, 550);
            Sales s_services = new Sales("24x7 Support", 100, 750);

            Sales[] products = { b_widget, a_widget, s_widget, b_services, a_services, s_services };
            foreach (Sales sale in products) {
                var n = sale.TotalSales();
                Console.WriteLine($"Total Sales {n}");
                

                
            }
        }
    }
}
