using DesignPatternBL.StructuralDesignPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.StructuralDesignPatterns.Proxy
{
    public interface IPayment
    {
        void Pay();
    }


    public class Cash : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Cash: Transaction.");
        }
    }

    public class CreditCard : IPayment
    {
        private Cash cash;

        public CreditCard(Cash realSubject)
        {
            cash = realSubject;
        }
        
        public void Pay()
        {
            if (CheckAccess())
            {
                cash.Pay();

                LogAccess();
            }
        }

        public bool CheckAccess()
        {
            Console.WriteLine("Proxy: Checking access to card.");

            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Proxy: money has been sent.");
        }
    }

    public class Client
    {
        public void ClientCode(IPayment subject)
        {
           
            subject.Pay();
            
        }

        public void ClientCode2(Composite.Composite tree, Soldier leaf)
        {
            throw new NotImplementedException();
        }
    }
}
