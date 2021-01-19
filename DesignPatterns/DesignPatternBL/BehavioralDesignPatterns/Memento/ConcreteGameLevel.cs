using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.BehavioralDesignPatterns.Memento
{
    public class ConcreteGameLevel : IMemento
    {
        private string _state;

        private DateTime _date;

        public ConcreteGameLevel(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        public string GetState()
        {
            return this._state;
        }


        public string GetName()
        {
            return $"{this._date} / ({this._state})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
