using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID.SOLID
{
    /// <summary>
    /// Сущності не повинні залежати від інтерфейсів, які вони використовують
    /// 
    /// </summary>
    interface ITeslaSet
    {
        void TeslaSet();
    }
    interface IBMWSet
    {
        void BMWSet();
    }
    interface IAudiSet
    {
        void AudiSet();
    }

    class Audi:IAudiSet
    {
        public void AudiSet()
        {
            throw new NotImplementedException();
        }
    }
    class BMW : IBMWSet
    {
        public void BMWSet()
        {
            throw new NotImplementedException();
        }
    }
    class Tesla : ITeslaSet
    {
        public void TeslaSet()
        {
            throw new NotImplementedException();
        }
    }

}
