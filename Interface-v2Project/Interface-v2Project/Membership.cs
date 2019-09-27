using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_v2Project {
    public class Membership : ICalcSales{
        public int Id;
        public string Name;
        public int Fee;
        public int Units;

        public decimal CalcSales() {
            return (decimal) (Fee * Units);
        }

        public Membership(int id, string name, int fee, int units) {
            this.Id = id;
            this.Name = name;
            this.Fee = fee;
            this.Units = units;
        }
    }
}
