using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.BehavioralDesignPatterns.State
{
    public class ATM
    {
        private State _state;

        public ATM(State state)
        {
            StateChanging(state);
        }

        public void StateChanging(State state)
        {
            Console.WriteLine($"ATM: Transition to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Request1()
        {
            _state.Handle1();
        }

        public void Request2()
        {
            _state.Handle2();
        }
    }

    public abstract class State
    {
        protected ATM Atm;

        public void SetContext(ATM atm)
        {
            Atm = atm;
        }

        public abstract void Handle1();

        public abstract void Handle2();
    }


    public class Active : State
    {
        public override void Handle1()
        {
            Console.WriteLine("Active: Log out from account.");
            Atm.StateChanging(new Disabled());
        }

        public override void Handle2()
        {
            Console.WriteLine("Active: performing operations.");
        }
    }

    public class Disabled : State
    {
        public override void Handle1()
        {
            Console.Write("Disabled: Checking some guest options.");
        }

        public override void Handle2()
        {
            Console.WriteLine("Disabled: Log into system.");
            Atm.StateChanging(new Active());
        }
    }
}
