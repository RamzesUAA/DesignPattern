using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.BehavioralDesignPatterns.Mediator
{
    public abstract class Mediator
    {
        public abstract void Send(string msg, Colleague colleague);
    }
    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
        public abstract void Notify(string message);
    }
    public class Student : Colleague
    {
        public Student(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to the student: " + message);
        }
    }
    // класс программиста
    public class Deanery : Colleague
    {
        public Deanery(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to the deanery: " + message);
        }
    }
    // класс тестера
    public class Professor : Colleague
    {
        public Professor(Mediator mediator)
            : base(mediator)
        { }

        public override void Notify(string message)
        {
            Console.WriteLine("Message to the professor: " + message);
        }
    }

   public class HeadmanOfTheGroup : Mediator
    {
        public Colleague Student { get; set; }
        public Colleague Deanery { get; set; }
        public Colleague Professor { get; set; }
        public override void Send(string msg, Colleague colleague)
        {
            if (Student == colleague)
                Deanery.Notify(msg);
            else if (Deanery == colleague)
                Professor.Notify(msg);
            else if (Professor == colleague)
                Student.Notify(msg);
        }
    }
}
