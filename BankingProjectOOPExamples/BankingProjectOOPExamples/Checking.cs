using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProjectOOPExamples {
   public class Checking :Account {
        
        private int LastCheckNumber = 0;
        public bool Pay(int CheckNumber, decimal Amount) {
            bool success = this.Withdraw(Amount);
            if (success) {
                this.LastCheckNumber = CheckNumber;
                return true;
            }
            return false;
        }
        public override string Print() { 
            return base.Print() + $"| {this.LastCheckNumber}";
        }

        public override void Save() {
            throw new NotImplementedException();
        }
    }
} 
