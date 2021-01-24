using System;

namespace Adapter
{
    public class MicroUSB
    {
        private string data;

        public MicroUSB(string data) => this.data = data;

        public string GetData()
        {
            Console.WriteLine($"Insert data to laptop: {data}");
            return data;
        }
    }
}
