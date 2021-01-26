using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Adapter;
using ConsoleApp1;
using DesignPatternBL.BehavioralDesignPatterns.Mediator;
using DesignPatternBL.BehavioralDesignPatterns.Memento;
using DesignPatternBL.BehavioralDesignPatterns.Observer;
using DesignPatternBL.BehavioralDesignPatterns.State;
using DesignPatternBL.BehavioralDesignPatterns.TemplateMethod;
using DesignPatternBL.CreationalDesignPatterns;
using DesignPatternBL.StructuralDesignPatterns.Bridge;
using DesignPatternBL.StructuralDesignPatterns.Decorator;
using Facade;
using Flyweight;

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
            /* ----- Without sync the threads ----- */
            //Singleton s1 = Singleton.getInstance();
            //Console.WriteLine(s1);
            //s1.query("SELECT * FROM library");

            /* ----- Width sync the threads ----- */
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


            /* ----------Memento----------*/
            //Game battlefield = new Game("Mission #1: Destroy the Russian oil station");
            //GameSaving gameTracker = new GameSaving(battlefield);

            //gameTracker.Backup();
            //battlefield.PlayGame("Mission #2: Kill Russian terrorist Sergey Medvedev");

            //gameTracker.Backup();
            //battlefield.PlayGame("Final mission: Ambush in Nigeria");

            //Console.WriteLine();
            //gameTracker.ShowHistory();

            //Console.WriteLine("\nRollback!\n");
            //gameTracker.Undo();

            //Console.WriteLine("\nRollback!\n");
            //gameTracker.Undo();





            /* ----------Mediator----------*/
            // The client code.
            //HeadmanOfTheGroup mediator = new HeadmanOfTheGroup();
            //Colleague student = new Student(mediator);
            //Colleague Deanery = new Deanery(mediator);
            //Colleague Professor = new Professor(mediator);
            //mediator.Student = student;
            //mediator.Deanery = Deanery;
            //mediator.Professor = Professor;
            //student.Send("Deanery");
            //Deanery.Send("Professor");
            //Professor.Send("Student");






            //* ----------Iterator----------*/
            //Collection collection = new Collection();
            //collection.InitializeItems(new Object[,]
            //{
            //    {1, 2, 3}, {4, 5, 6}, {7, 8, 9}
            //});
            //var iterator = collection.CreateIterator();
            //iterator.Step = 1;
            //Console.WriteLine("Iterating over collection:");
            //for (var item = iterator.First();
            //    !iterator.IsDone;
            //    item = iterator.Next())
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("Reverse Iterating over collection:");
            //var reverseIterator = collection.CreateReverseIterator();
            //reverseIterator.Step = 1;
            //for (var item = reverseIterator.First();
            //    !reverseIterator.IsDone;
            //    item = reverseIterator.Next())
            //{
            //    Console.WriteLine(item);
            //}




            ////* ----------Observer----------*/
            //var subject = new Alarm();
            //var user1 = new User1();
            //subject.SetClock(user1);

            //var user2 = new User2();
            //subject.SetClock(user2);

            //var user3 = new User3();
            //subject.SetClock(user3);

            //subject.SomeBusinessLogic();

            //subject.CancelClock(user1);
            //subject.CancelClock(user2);




            //* ----------State----------*/
            //ATM atm = new ATM(new Disabled());
            //atm.Request2();
            //atm.Request2();
            //atm.Request1();




            ////* ----------TemplateMethod----------*/
            //Player.PlayerGame(new Casino());
            //Console.WriteLine("------------------------");
            //Player.PlayerGame(new Monopoly());



            ////* ----------Strategy----------*/
            //var list = new List<int>();
            //list.Add(3);
            //list.Add(8);
            //list.Add(1);
            //list.Add(5);
            //list.Add(9);
            //var worker = new Context();
            //worker.Iterate(new Algorithm1(), list);
            //worker.Iterate(new Algorithm2(), list);
            //Console.ReadKey();






            ////* ----------Adapter----------*/
            //Laptop laptop = new USBPort(new MicroUSB("New information"));
            //laptop.GetData();

            //Console.WriteLine($"Data from laptop: {laptop.DatafromMicro}");





            ////* ----------Facade----------*/
            //var washMashine = new Washmashine(new Washing(), new Squeeze());

            //Console.WriteLine("Washing of cotton:");
            //washMashine.CottonWashing();
            //Console.WriteLine();

            //Console.WriteLine("Washing of synthetics:");
            //washMashine.SyntheticsWashing();


            ///* ----------Bridge----------*/
            //ThreeDPrinter printer = new Canon(new Solid());
            //printer.Print();
            //printer.GetDetail();
            //printer.Material = new Liquid();
            //printer.Print();
            //printer.GetDetail();




            ///* ----------Flyweight----------*/
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            //Console.Clear();
            //Console.ForegroundColor = ConsoleColor.White;

            //decimal power = (decimal)0.1;
            //AntHill antHill = new AntHill();
            //for (int i = 0; i < 5; i++)
            //{
            //    Ant blackAnt = antHill.GetAnt("Black");
            //    if (blackAnt != null)
            //        blackAnt.Exist((double)power);
            //    power += (decimal)0.1;
            //}

            //for (int i = 0; i < 5; i++)
            //{
            //    Ant redAnt = antHill.GetAnt("Red");
            //    if (redAnt != null)
            //        redAnt.Exist((double)power);
            //    power += (decimal)0.1;
            //}


            ////* ----------Proxy----------*/
            //Client client = new Client();

            //Console.WriteLine("Client: Executing the client code with a cash:");
            //Cash realSubject = new Cash();
            //client.ClientCode(realSubject);

            //Console.WriteLine();

            //Console.WriteLine("Client: Executing the same client code with a credit card:");
            //CreditCard proxy = new CreditCard(realSubject);
            //client.ClientCode(proxy);




            ////* ----------Composite----------*/
            //Client client = new Client();

            //Soldier soldier = new Soldier();
            //Console.WriteLine("Client: I get a simple body:");
            //client.ClientCode(soldier);

            //Composite army = new Composite();
            //Composite division1 = new Composite();
            //division1.Add(new Soldier());
            //division1.Add(new Soldier());
            //Composite division2 = new Composite();
            //division2.Add(new Soldier());
            //army.Add(division1);
            //army.Add(division2);
            //Console.WriteLine("Client: Now I've got a composite army:");
            //client.ClientCode(army);

            //Console.Write("Client: I don't need to check the components classes even when managing the army:\n");
            //client.ClientCode2(army, soldier);




            ////* ----------Decorator----------*/
            Client client = new Client();

            var simple = new ConcreteBody();
            Console.WriteLine("Client: I get a simple body:");
            client.ClientCode(simple);
            Console.WriteLine();

            Jacket decorator1 = new Jacket(simple);
            Сloak decorator2 = new Сloak(decorator1);
            Console.WriteLine("Client: Now I've got a decorated body:");
            client.ClientCode(decorator2);
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
