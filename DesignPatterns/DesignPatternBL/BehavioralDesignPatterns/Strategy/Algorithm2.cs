using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Algorithm2 : IAlgorithm
    {
        public void Iterate(List<int> collection)
        {
            for (int i = collection.Count -1; i >= 0 ; i--)
            {
                Console.WriteLine($"collection[{i}]: {collection[i]}");
            }
            Console.WriteLine();
        }
    }
}
