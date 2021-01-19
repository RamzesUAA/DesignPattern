using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternBL.BehavioralDesignPatterns.Memento
{
    public class GameSaving
    {
        private List<IMemento> _mementos = new List<IMemento>();

        private Game _originator = null;

        public GameSaving(Game originator)
        {
            this._originator = originator;
        }

        public void Backup()
        {
            Console.WriteLine("\nNotification: Making backup");
            this._mementos.Add(this._originator.Save());
        }

        public void Undo()
        {
            if (this._mementos.Count == 0)
            {
                return;
            }

            var memento = this._mementos.Last();
            this._mementos.Remove(memento);

            Console.WriteLine("Notification: Restoring state of the game to: " + memento.GetName());

            try
            {
                this._originator.Restore(memento);
            }
            catch (Exception)
            {
                this.Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Notification: Here's the list of saved stages of the game:");

            foreach (var memento in this._mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }

}
