using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID.WRONG_SOLID
{
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }

        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }
    }

    public class TransferManager
    {
        public BankAccount Source { get; set; }
        public BankAccount Destination { get; set; }
        public decimal Value { get; set; }

        public void Transfer()
        {
            Source.RemoveFunds(Value);
            Destination.AddFunds(Value);
        }
    }

}
