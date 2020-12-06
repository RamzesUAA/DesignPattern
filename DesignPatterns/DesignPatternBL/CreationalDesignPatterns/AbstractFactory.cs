using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.CreationalDesignPatterns
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();

    }

    public class VictorianFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }
        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
        public override string ToString()
        {
            return "Victorian Factory";
        }
    }
    public class ModernFactory : IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }
        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public override string ToString()
        {
            return "Modern Factory";
        }
    }

    public interface IChair
    {
        void hasLegs();
        void sitOn();
    }

    public interface ISofa
    {
        void hasLegs();
        void hasBack();
        void sitOn();
        void lieOn();
    }


    class VictorianChair :IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian chair has legs");
        }

        public void sitOn()
        {
            Console.WriteLine("You can sit on the victorian chair");
        }
    }
    class ModernChair : IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("Modern chair has legs");
        }

        public void sitOn()
        {
            Console.WriteLine("You can sit on the modern chair");
        }
    }


    class VictorianSofa : ISofa
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian sofa has legs");
        }

        public void hasBack()
        {
            Console.WriteLine("Victorian sofa has a back");
        }

        public void sitOn()
        {
            Console.WriteLine("You can sit on the victorian sofa");
        }

        public void lieOn()
        {
            Console.WriteLine("You can lie on the victorian sofa");
        }
    }
    class ModernSofa : ISofa
    {
        public void hasLegs()
        {
            Console.WriteLine("Modern sofa has legs");
        }

        public void hasBack()
        {
            Console.WriteLine("Modern sofa has a back");
        }

        public void sitOn()
        {
            Console.WriteLine("You can sit on the modern sofa");
        }

        public void lieOn()
        {
            Console.WriteLine("You can lie on the modern sofa");
        }
    }

}
