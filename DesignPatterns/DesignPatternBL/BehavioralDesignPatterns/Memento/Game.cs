using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DesignPatternBL.BehavioralDesignPatterns.Memento
{
    public class Game
    {
     
        private string _gameState;

        public Game(string state)
        {
            this._gameState = state;
            Console.WriteLine("Notification: Fitst saved moment: " + state);
        }

        public void PlayGame(string momentToSave)
        {
            Console.WriteLine("Notification: Saving current progress ...");
            this._gameState = momentToSave;
            Console.WriteLine($"Notification: My progress has changed to: {_gameState}");
        }
        public IMemento Save()
        {
            return new ConcreteGameLevel(this._gameState);
        }

        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteGameLevel))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            this._gameState = memento.GetState();
            Console.Write($"Notification: State of the game has changed to: {_gameState}");
        }
    }
}
