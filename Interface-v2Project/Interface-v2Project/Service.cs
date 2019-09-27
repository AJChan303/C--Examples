using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_v2Project {
    public class Service :ICalcSales{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }
        public int Hours { get; set; }

        public decimal CalcSales() {
            return this.Rate * this.Hours;
        }
        public string About() {
            return "About Services";
        }
        
        public Service(int id, string name, decimal rate, int hours) {
            this.Id = id;
            this.Name = name;
            this.Rate = rate;
            this.Hours = hours;
        }
    }
}
    

