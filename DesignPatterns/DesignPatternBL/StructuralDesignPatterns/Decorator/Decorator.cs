using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.StructuralDesignPatterns.Decorator
{
    public abstract class Body
    {
        public abstract string Operation();
    }

    public class ConcreteBody : Body
    {
        public override string Operation()
        {
            return "ConcreteBody";
        }
    }

    public abstract class Decorator : Body
    {
        protected Body Body;

        public Decorator(Body body)
        {
            Body = body;
        }

        public void SetComponent(Body body)
        {
            Body = body;
        }

        public override string Operation()
        {
            if (Body != null)
            {
                return Body.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    public class Jacket : Decorator
    {
        public Jacket(Body comp) : base(comp)
        {
        }
        
        public override string Operation()
        {
            return $"Jacket({base.Operation()})";
        }
    }

    public class Сloak : Decorator
    {
        public Сloak(Body comp) : base(comp)
        {
        }

        public override string Operation()
        {
            return $"Сloak({base.Operation()})";
        }
    }

    public class Client
    {
        public void ClientCode(Body body)
        {
            Console.WriteLine("RESULT: " + body.Operation());
        }
    }
}
