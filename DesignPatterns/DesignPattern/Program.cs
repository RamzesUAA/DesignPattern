using System;
using DesignPatternBL.CreationalDesignPatterns;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ----------Factory Method----------*/
            //Logistic roadLogistic = new RoadLogistics();
            //roadLogistic.planDelivery();

            //Logistic seaLogistic = new SeaLogistics();
            //seaLogistic.planDelivery();

            //Logistic planeLogistic = new AirLogistics();
            //planeLogistic.planDelivery();



            /* ----------Abstract Factory----------*/
            //ClientMethod(new VictorianFactory());
            //ClientMethod(new ModernFactory());


            /* ----------Builder----------*/
            //var director = new Director();
            //var builder = new HouseBuilder();
            //director.Builder = builder;
            //Console.WriteLine("Huge house");
            //director.buildHugeHouse();
            //Console.WriteLine(builder.GetHouse().HouseInfo());
            //Console.WriteLine("Small house");
            //director.buildSmallHouse();
            //Console.WriteLine(builder.GetHouse().HouseInfo());

        }

        public static void ClientMethod(IFurnitureFactory factory)
        {
            Console.WriteLine($"---------------Order in {factory}---------------");
            var chair = factory.CreateChair();
            chair.hasLegs();
            chair.sitOn();
            var sofa = factory.CreateSofa();
            sofa.hasBack();
            sofa.hasLegs();
            sofa.lieOn();
            sofa.sitOn();
        }
    }
}
