using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.BehavioralDesignPatterns.Memento
{
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
