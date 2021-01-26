using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternBL.StructuralDesignPatterns.Bridge
{
    public interface IMaterial
    {
        void Info();
    }

    public class Solid : IMaterial
    {
        public void Info()
        {
            Console.WriteLine("Used solid material");
        }
    }

    public class Liquid : IMaterial
    {
        public void Info()
        {
            Console.WriteLine("Used liquid material");
        }
    }

    public abstract class ThreeDPrinter
    {
        protected IMaterial material;
        public IMaterial Material
        {
            set { material = value; }
        }
        public ThreeDPrinter(IMaterial lang)
        {
            material = lang;
        }
        public virtual void Print()
        {
            material.Info();
        }
        public abstract void GetDetail();
    }

    public class Canon : ThreeDPrinter
    {
        public Canon(IMaterial lang) : base(lang)
        {
        }
        public override void GetDetail()
        {
            Console.WriteLine("Gets printeds detail");
        }
    }
}
