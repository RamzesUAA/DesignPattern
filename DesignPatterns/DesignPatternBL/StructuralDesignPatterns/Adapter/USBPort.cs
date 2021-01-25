namespace Adapter
{
    public class USBPort : Laptop
    {
        private MicroUSB microUSB;

        public USBPort(MicroUSB micro) => microUSB = micro;

        public override void GetData()
        {
            base.GetData();
            DatafromMicro = microUSB.GetData();
        }
    }
}
