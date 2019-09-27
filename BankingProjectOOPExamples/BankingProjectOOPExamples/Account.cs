﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankingProjectOOPExamples {
    public abstract  class Account {

        public string Number { get; set; }
        private decimal Balance { get; set; } = 0.0M; // M = decimal
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;

        public abstract void Save();

        public virtual string Print() {
            return $"{this.Number} | {this.Balance} | {this.Name}";
        }

        public bool TransferTo(Account ToAccount, decimal Amount) {
            bool success = this.Withdraw(Amount);
            if( success) {
                ToAccount.Deposit(Amount);
                return true;
            }
            return false;
        }

        public bool Deposit(decimal Amount) {
            if (Amount <= 0) {
                Console.WriteLine("Deposit amounts must be greater than zero");
                return false;
            }
            else {
                this.Balance += Amount;
                return true;
            }
        }

        public bool Withdraw(decimal Amount) {
            if (Amount <= 0) {
                
                Console.WriteLine("Withdraw amount must be GT zero");
                return false;
                
            } else {
                if (this.Balance >= Amount) {
                    this.Balance -= Amount;
                    return true;
                }
            }
            return false;
        }
        public decimal GetBalance() {
            return this.Balance;
        }
    }
    }