using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternBL.BehavioralDesignPatterns.Observer
{

    public interface IObserver
    {
        void UseClock(IAlarmAdjust subject);
    }

    public interface IAlarmAdjust
    {
        void SetClock(IObserver observer);
        
        void CancelClock(IObserver observer);

        void Ring();
    }

    public class Alarm : IAlarmAdjust
    {
      
        public int Time { get; set; }

       
        private List<IObserver> _observers = new List<IObserver>();

     
        public void SetClock(IObserver observer)
        {
            Console.WriteLine("Alarm: clock has been set.");
           _observers.Add(observer);
        }

        public void CancelClock(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("Alarm: clock has been cancelled.");
        }

        public void Ring()
        {
            Console.WriteLine("Alarm: Wake the f*** Up Samurai.");

            foreach (var observer in _observers)
            {
                observer.UseClock(this);
            }
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine("\nAlarm: starting to ring.");
            Time = new Random().Next(0, 12);

            Thread.Sleep(15);

            Console.WriteLine("Subject: Time has changed to: " + Time);
            Ring();
        }
    }

    public class User1 : IObserver
    {
        public void UseClock(IAlarmAdjust subject)
        {
            if ((subject as Alarm).Time < 3)
            {
                Console.WriteLine("User1: Woke up after clock rung.");
            }
        }
    }

    public class User2 : IObserver
    {
        public void UseClock(IAlarmAdjust subject)
        {
            if ((subject as Alarm).Time == 0 || (subject as Alarm).Time >= 2)
            {
                Console.WriteLine("User2: Woke up after clock rung.");
            }
        }
    }
    public class User3 : IObserver
    {
        public void UseClock(IAlarmAdjust subject)
        {
            //if (subject is Alarm alarm && alarm.Time == 0 ||  alarm.Time >= 2)
            //{
            //    Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            //}
            if ((subject as Alarm).Time > 7)
            {
                Console.WriteLine("User3: Woke up after clock rung.");
            }
        }
    }
}
            