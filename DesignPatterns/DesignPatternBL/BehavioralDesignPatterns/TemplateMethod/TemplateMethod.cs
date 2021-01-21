using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.BehavioralDesignPatterns.TemplateMethod
{
    public abstract class Game
    {
        public void TemplateMethod()
        {
            StartGame();
            PlayGame();
            LeaveGame();

        }
        //protected void BaseOperation1()
        //{
        //    Console.WriteLine("AbstractClass says: I am doing the bulk of the work");
        //}

        //protected void BaseOperation2()
        //{
        //    Console.WriteLine("AbstractClass says: But I let subclasses override some operations");
        //}

        //protected void BaseOperation3()
        //{
        //    Console.WriteLine("AbstractClass says: But I am doing the bulk of the work anyway");
        //}

        public virtual void PlayGame()
        {
            Console.WriteLine("Play casino");
        }

        protected abstract void LeaveGame();
        protected abstract void StartGame();

    }

    public class Casino : Game
    {
        protected override void LeaveGame()
        {
            Console.WriteLine("Leaving the game");
        }
        protected override void StartGame()
        {
            Console.WriteLine("Starting to play casino");
        }
    }


    public class Monopoly : Game
    {
        protected override void LeaveGame()
        {
            Console.WriteLine("Leaving the monopoly");
        }
        protected override void StartGame()
        {
            Console.WriteLine("Starting to play monopoly");
        }
    }

    public class Player
    {

        public static void  PlayerGame(Game abstractClass)
        {
            abstractClass.TemplateMethod();

        }
    }

}
