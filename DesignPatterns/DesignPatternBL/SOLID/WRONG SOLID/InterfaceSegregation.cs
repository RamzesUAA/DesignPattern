using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.SOLID.WRONG_SOLID
{
    interface AutoSet
    {
        void TeslaSet();
        void BMWSet();
        void AudiSet();
    }

    class Audi : AutoSet
    {
        public void TeslaSet()
        {
            throw new NotImplementedException();
        }

        public void BMWSet()
        {
            throw new NotImplementedException();
        }

        public void AudiSet()
        {
            throw new NotImplementedException();
        }
    }
    class BMW : AutoSet
    {
        public void TeslaSet()
        {
            throw new NotImplementedException();
        }

        public void BMWSet()
        {
            throw new NotImplementedException();
        }

        public void AudiSet()
        {
            throw new NotImplementedException();
        }
    }
    class Tesla : AutoSet
    {
        public void TeslaSet()
        {
            throw new NotImplementedException();
        }

        public void BMWSet()
        {
            throw new NotImplementedException();
        }

        public void AudiSet()
        {
            throw new NotImplementedException();
        }
    }
}
