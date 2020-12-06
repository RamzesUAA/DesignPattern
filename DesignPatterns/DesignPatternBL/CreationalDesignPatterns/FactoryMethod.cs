using System;

namespace DesignPatternBL.CreationalDesignPatterns
{
    public abstract class Logistic
    {
        public void planDelivery()
        {
            ITransport transport = CreateTransport();
        }
        public abstract ITransport CreateTransport();
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------

    public class RoadLogistics : Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
    public class SeaLogistics : Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
    public class AirLogistics : Logistic
    {
        public override ITransport CreateTransport()
        {
            return new Plain();
        }
    }

    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------

    public interface ITransport
    {
        void Deliver();
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------

    public class Truck:ITransport
    {
        public Truck()
        {
            Deliver();
        }
        public void Deliver()
        {
            Console.WriteLine("Delivering by track");
        }
    }

    public class Plain : ITransport
    {
        public Plain()
        {
            Deliver();
        }
        public void Deliver()
        {
            Console.WriteLine("Delivering by plain");
        }
    }

    public class Ship:ITransport
    {
        public Ship()
        {
            Deliver();
        }
        public void Deliver()
        {
            Console.WriteLine("Delivering by ship");
        }
    }

}
