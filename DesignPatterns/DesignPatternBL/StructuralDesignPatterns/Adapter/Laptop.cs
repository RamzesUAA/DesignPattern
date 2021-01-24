using System;

namespace Adapter
{
    public class Laptop
    {
        private string dataFromMicro;

        public string DatafromMicro { get => dataFromMicro; set => dataFromMicro = value; }

        public virtual void GetData()
        {
            Console.WriteLine("Get data from micro USB");
        }
    }
}
