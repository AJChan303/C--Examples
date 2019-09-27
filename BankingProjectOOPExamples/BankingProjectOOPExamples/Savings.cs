using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProjectOOPExamples {
    public class Savings : Account {

        public double IntRate { get; set; } = 0.03;

        public void PayInterest(decimal amountofinterest) {
            this.Deposit(amountofinterest);
        }

        public override string Print() {
            return base.Print() + $"| {IntRate}";
        }
        public decimal CalcInterest(int months) {
            double InterestToBePaid = this.IntRate / 12 * months * (double)this.GetBalance();
            return (decimal)InterestToBePaid;
        }
        public bool ChangeRate(double chgRate) {
          
                

                if ((this.IntRate + chgRate)<0 || chgRate > 0.5) {
                Console.WriteLine("Interest rate change must be less than 50% or the outcome must be greater than 0");
                    return false;
                }
                this.IntRate += chgRate;
                Console.WriteLine($"Your new interest rate is {this.IntRate}");
                return true;
            }

        public override void Save() {
            throw new NotImplementedException();
        }
    }
        //public bool ModifyIntRate(double Amount) {
        //    if (Amount > .5) {

        //        if ((this.IntRate += Amount) < 0) {
        //            Console.WriteLine("Interest must be greater than 0 after changes");
        //        return false;

        //    }
        //         Console.WriteLine("Interest modifier must be less than .5");
        //    return false;

        //    }
        //    Console.WriteLine($"Your new interest rate {this.IntRate}");
        //    this.IntRate += Amount;
        //    return true;

        //}
    
        }
