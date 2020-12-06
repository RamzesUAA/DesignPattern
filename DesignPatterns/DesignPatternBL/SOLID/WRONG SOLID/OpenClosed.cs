using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternBL.SOLID.WRONG_SOLID
{
    class Logger
    {
        public void Log(string message, LogType logType)
        {
            switch (logType)
            {
                case LogType.Console:
                    Console.WriteLine(message);
                    break;
                case LogType.File:
                    using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate))
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(message);
                        fs.WriteAsync(bytes, 0, bytes.Length);
                    }
                    break;
            }
        }

    }
    public enum LogType
    {
        Console,
        File
    }
}
