using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.StructuralDesignPatterns.Composite
{
    public abstract class Component
    {
        public Component() { }


        public abstract string Operation();


        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }


        public virtual bool IsComposite()
        {
            return true;
        }
    }
    public class Soldier : Component
    {
        public override string Operation()
        {
            return "Soldier";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }

    public class Composite : Component
    {
        protected List<Component> _soldier = new List<Component>();

        public override void Add(Component component)
        {
            _soldier.Add(component);
        }

        public override void Remove(Component component)
        {
            _soldier.Remove(component);
        }


        public override string Operation()
        {
            int i = 0;
            string result = "Squad(";

            foreach (Component component in _soldier)
            {
                result += component.Operation();
                if (i != _soldier.Count - 1)
                {
                    result += "+";
                }
                i++;
            }
            return result + ")";
        }
    }

    public class Client
    {

        public void ClientCode(Component soldier)
        {
            Console.WriteLine($"RESULT: {soldier.Operation()}\n");
        }

        public void ClientCode2(Component component1, Component component2)
        {
            if (component1.IsComposite())
            {
                component1.Add(component2);
            }

            Console.WriteLine($"RESULT: {component1.Operation()}");
        }
    }
}
