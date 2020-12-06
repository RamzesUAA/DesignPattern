using System;
using System.Threading;
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



            /* ----------Prototype----------*/
            //Robot robot1 = new Robot();
            //robot1.Name = "Ybivatel";
            //robot1.CreationDate = Convert.ToDateTime("1977-01-01");
            //robot1.RobotInfo = new RobotInfo(123);

            //Robot robot2 = (Robot)robot1.ShallowCopy();
            //Robot robot3 = (Robot)robot1.DeepClone();
            //Console.WriteLine();
            //Console.WriteLine("Original values of p1, p2, p3:");
            //Console.WriteLine("   robot1 instance values: ");
            //DisplayValues(robot1);
            //Console.WriteLine("   robot2 instance values:");
            //DisplayValues(robot2);
            //Console.WriteLine("   robot3 instance values:");
            //DisplayValues(robot3);

            //robot1.CreationDate = Convert.ToDateTime("1900-01-01");
            //robot1.Name = "Frank";
            //robot1.RobotInfo.IdNumber = 4321;
            //Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            //Console.WriteLine("   robot1 instance values: ");
            //DisplayValues(robot1);
            //Console.WriteLine("   robot2 instance values (reference values have changed):");
            //DisplayValues(robot2);
            //Console.WriteLine("   robot3 instance values (everything was kept the same):");
            //DisplayValues(robot3);



            /* ----------Singleton----------*/
            // Without sync the threads
            //Singleton s1 = Singleton.getInstance();
            //Console.WriteLine(s1);
            //s1.query("SELECT * FROM library");

            // Width sync the threads

            //    Console.WriteLine(
            //        "{0}\n{1}\n\n{2}\n",
            //        "If you see the same value, then singleton was reused (yay!)",
            //        "If you see different values, then 2 singletons were created (booo!!)",
            //        "RESULT:"
            //    );
            //    Thread process1 = new Thread(() =>
            //    {
            //        TestSingleton("MSSQL");
            //    });
            //    Thread process2 = new Thread(() =>
            //    {
            //        TestSingleton("MySQL");
            //    });
            //    process1.Start();
            //    process2.Start();

            //    process1.Join();
            //    process2.Join();
            //    TestSingleton("PostgreSQL");



            /* ----------Singleton----------*/



        }

        public static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine(singleton.Value);
        }

        public static void DisplayValues(Robot p)
        {
            Console.WriteLine($"      Name: {p.Name}, BirthDate: {p.CreationDate}");
            Console.WriteLine("      ID#: {0:d}", p.RobotInfo.IdNumber);
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
