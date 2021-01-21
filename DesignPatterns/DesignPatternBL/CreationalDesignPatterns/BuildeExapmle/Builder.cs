using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternBL.CreationalDesignPatterns.MoreExamples
{
    // builder pattern: сформувати замовлення(наприклад випічки), 
    // де можна опціонально додавати інградієнти(2-3 інградієнти). 

    public abstract class BunBuilder
    {
        public abstract void AddPoppy();
        public abstract void AddChocolate();
        public abstract void AddJam();
        public abstract OrderBun GetResult();
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    public class OrderBun
    {
        List<string> ingredients = new List<string>();
        public void Add(string ingredient)
        {
            ingredients.Add(ingredient);
        }
        public override string ToString()
        {
            string ingradientsResult = "Bun with:";
            foreach (var ingredient in ingredients)
            {
                ingradientsResult += $"{ingredient} ";
            }
            return ingradientsResult;
        }
    }
    //--------------------------------------------------------------------------------
    //--------------------------------------------------------------------------------
    public class ConcreteBunBuilder : BunBuilder
    {
        OrderBun bun = new OrderBun();
        public override void AddPoppy()
        {
            bun.Add("Poppy");
        }
        public override void AddChocolate()
        {
            bun.Add("Chocolate");
        }
        public override void AddJam()
        {
            bun.Add("Jam");
        }
        public override OrderBun GetResult()
        {
            return bun;
        }
    }





    //public class Poppy 
    //{
    //    public override string ToString()
    //    {
    //        return "Poppy";
    //    }

    //    public static implicit operator string(Poppy v)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public class Chocolate
    //{
    //    public override string ToString()
    //    {
    //        return "Chocolate";
    //    }

    //    public static implicit operator string(Chocolate v)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //public class Jam
    //{
    //    public override string ToString()
    //    {
    //        return "Jam";
    //    }

    //    public static implicit operator string(Jam v)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //public abstract class BunBuilder
    //{
    //    public Bun Bun { get; private set; }
    //    public void CreateBread()
    //    {
    //        Bun = new Bun();
    //    }
    //    public abstract void SetFlour();
    //    public abstract void SetSalt();
    //    public abstract void SetAgg();
    //    public abstract void SetIngradient();
    //}
    //public class Bun
    //{
    //    public int flour { get; set; }
    //    public int salt { get; set; }
    //    public int egg { get; set; }
    //    public string Poppy { get; set; }
    //    public string Chocolate { get; set; }
    //    public string Jam { get; set; }
    //    public override string ToString()
    //    {
    //        StringBuilder sb = new StringBuilder();

    //        if (flour != null)
    //            sb.Append(flour + "g\n");
    //        if (salt != null)
    //            sb.Append(salt + "g\n");
    //        if (egg != null)
    //            sb.Append(egg + "g\n");
    //        if (Poppy != null)
    //            sb.Append("Poppy\n");
    //        if (Chocolate != null)
    //            sb.Append("Chocolate\n");
    //        if (Jam != null)
    //            sb.Append("Jam\n");
    //        return sb.ToString();
    //    }
    //}

    //public class MakePoppyBun : BunBuilder
    //{
    //    public override void SetAgg()
    //    {
    //        this.Bun.egg = 2;
    //    }

    //    public override void SetFlour()
    //    {
    //        this.Bun.flour = 300;
    //    }

    //    public override void SetIngradient()
    //    {
    //        this.Bun.Poppy = new Poppy();
    //    }

    //    public override void SetSalt()
    //    {
    //        this.Bun.salt = 20;
    //    }

    //}
    //public class MakeJamBun : BunBuilder
    //{
    //    public override void SetAgg()
    //    {
    //        this.Bun.egg = 2;
    //    }

    //    public override void SetFlour()
    //    {
    //        this.Bun.flour = 250;
    //    }

    //    public override void SetIngradient()
    //    {
    //        this.Bun.Jam = new Jam();
    //    }

    //    public override void SetSalt()
    //    {
    //        this.Bun.salt = 20;
    //    }
    //}
    //public class MakeChocolateBun : BunBuilder
    //{
    //    public override void SetAgg()
    //    {
    //        this.Bun.egg = 1;
    //    }

    //    public override void SetFlour()
    //    {
    //        this.Bun.flour = 400;
    //    }

    //    public override void SetIngradient()
    //    {
    //        this.Bun.Chocolate = new Chocolate();
    //    }

    //    public override void SetSalt()
    //    {
    //        this.Bun.salt = 10;
    //    }
    //}
}

