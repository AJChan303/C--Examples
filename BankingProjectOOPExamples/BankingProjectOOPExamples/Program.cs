using System;

namespace BankingProjectOOPExamples {
    class Program {
        static void Main(string[] args) {

            

            MoneyMarket mon = new MoneyMarket();
            mon.Number = "1003";
            mon.Name = "MM Account";
            mon.MMRate = .05;
            mon.Deposit(200);
            mon.Withdraw(100);
            mon.PayInterest(12);
            decimal monbal = mon.GetBalance();
           // Console.WriteLine($"{ monbal}");

            Savings sav1 = new Savings();
            sav1.Number = "SAV001";
            sav1.Name = "My Savings Account";
            sav1.Deposit(100);
            sav1.ChangeRate(.03);
            //  sav1.ChangeRate(-.08);
            // sav1.ChangeRate(.6);
            
            Checking chk = new Checking();
            chk.Name = "My Checking Account";
            chk.Number = "Chk001";
            chk.Deposit(100);
            chk.Pay(1000, 50);
            Account[] accounts ={ sav1, mon, chk };
            foreach (Account acct in accounts) {
                Console.WriteLine(acct.Print());
            }
            
            /*
            bool ItWorked = mon.TransferTo(sav1, 150);
            Console.WriteLine($"MM Balance {mon.GetBalance()}");
            Console.WriteLine($"Sav1 Balance {sav1.GetBalance()}");
           
            Console.WriteLine(sav1.Print());
            Console.WriteLine(mon.Print());
            /*
            Savings sav = new Savings();
            sav.Number = "1002";
            sav.Name = "Savings 1";
            sav.IntRate = .05;
            
            sav.Deposit(200);
            sav.Withdraw(100);

            decimal InterestToBePaid = sav.CalcInterest(6);
            sav.PayInterest(InterestToBePaid);
            decimal savbal = sav.GetBalance();
            //Console.WriteLine($"{savbal}");
            //sav.Deposit(-10);
            //sav.Withdraw(-10);
            //sav.Withdraw(25);
            //savbal = sav.GetBalance();
          Console.WriteLine($"{savbal}");


            /*
                        Account acct = new Account();
                        acct.Number = "1001";
                        acct.Name = "Test Account";
                        acct.Deposit(20);
                        acct.Withdraw(10);
                        decimal balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Deposit(-10);
                         balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Withdraw(-10);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");
                        acct.Withdraw(20);
                        balance = acct.GetBalance();
                        Console.WriteLine($"Account balance is {balance} (should be 10)");


                */
        }
    }
}
