using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.СhainOfResponsibility
{
    // Chane of responsibilities: реалізувати систему переказу грошей, сформувати ланцюжок запит
    // у з двома обробниками( BankTransfer, PayPallTransfer) і відповідності до вибраного клієнтом 
    // способу робити відправку грошей
    public class Client
    {
        public static void ClientCode(AbstractHandler handler)
        {
            foreach (var money in new List<string> { "Bitcoin", "Cash", "MoneyOnCard" })
            {
                var result = handler.Handle(money);

                if (result != null)
                {
                    Console.Write($"   {result}");
                }
                else
                {
                    Console.WriteLine($"   {money} weren`t sent.");
                }
            }
        }
    }
}
