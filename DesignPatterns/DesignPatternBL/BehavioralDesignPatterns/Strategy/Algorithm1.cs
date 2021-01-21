using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Algorithm1 : IAlgorithm
    {
        public void Iterate(List<int> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.WriteLine($"collection[{i}]: {collection[i]}");
            }
            Console.WriteLine();
        }
    }

}
