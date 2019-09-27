using System;
using System.Collections.Generic;
using System.Text;
// basic widgete advanced widget supreme widget
namespace OOPProductsServices {
    public class Sales {
        
        public string Name;
        public decimal Price;
        public decimal Units;

        public Sales(string Name, decimal Price, int Units) {
            this.Name = Name;
            this.Price = Price;
            this.Units = Units;
        }
        public String Print() {

        }
         public decimal TotalSales() {
            return this.Price * this.Units;
        }
    }
}
