using System;
using System.Collections.Generic;

namespace Flyweight
{
  
    public abstract class Ant
    {
        protected string color; 

        public abstract void Exist(double power);
    }

    public class BlackAnt : Ant
    {
        public BlackAnt()
        {
            color = "black";
        }

        public override void Exist(double power)
        {
            Console.WriteLine($"There is black ant with power: {power}");
        }
    }
    public class RedAnt : Ant
    {
        public RedAnt()
        {
            color = "red";
        }

        public override void Exist(double power)
        {
            Console.WriteLine($"There is red ant with power: {power}");
        }
    }

    public class AntHill
    {
        Dictionary<string, Ant> ants = new Dictionary<string, Ant>();
        public AntHill()
        {
            ants.Add("Black", new BlackAnt());
            ants.Add("Red", new RedAnt());
        }

        public Ant GetAnt(string key)
        {
            if (ants.ContainsKey(key))
                return ants[key];
            else
                return null;
        }
    }
}
