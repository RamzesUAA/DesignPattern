using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DesignPatternBL.SOLID.SOLID
{
    /// <summary>
    /// Модулі вищих рівнів не повинні залежати від модулів низьких рівнів
    /// Вони обоє повинні залежати від абстракцій, абстракції не повинні залежати від деталей
    /// Деталі повинні залежати від абстракцій
    /// </summary>
    public interface ITransferSource
    {
        void RemoveFunds(decimal value);
    }

    public interface ITransferDestination
    {
        void AddFunds(decimal value);
    }

    public  class BankAccount : ITransferSource, ITransferDestination
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }
    }

    public class TransferManager
    {
        public ITransferSource Source { get; set; }
        public ITransferDestination Destination { get; set; }
        private  decimal Value { get; set; }

        public void Transfer()
        {
            Source.RemoveFunds(Value);
            Destination.AddFunds(Value);
        }
    }
}
