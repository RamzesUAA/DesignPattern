using System;

namespace DesignPatternBL.CreationalDesignPatterns
{
    //public class Singleton
    //{

    //    private Singleton(){}
    //    private static Singleton Database;

    //    public static Singleton getInstance()
    //    {
    //        if (Database == null)
    //        {
    //            Database = new Singleton();
    //        }

    //        return Database;
    //    }

    //    public void query(string sql)
    //    {
    //        Console.WriteLine($"SQL query: [{sql}]");
    //    }
    //}


    public class Singleton
    {
        private Singleton()
        {
        }

        private static Singleton Database;

      
        private static readonly object _lock = new object();

        public static Singleton GetInstance(string value)
        {
            if (Database == null)
            {
                lock (_lock)
                {

                    if (Database == null)
                    {
                        Database = new Singleton();
                        Database.Value = value;
                    }
                }
            }

            return Database;
        }
        public string Value { get; set; }
    }
}

