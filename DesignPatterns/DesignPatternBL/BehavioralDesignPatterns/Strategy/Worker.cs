using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Context
    {
        public void Iterate(IAlgorithm alg, List<int> list)
        {
            if(alg != null)
            {
                alg.Iterate(list);
            }
            else
            {
                Console.WriteLine("No data");
            }
        }
    }
}
