using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternBL.SOLID.SOLID
{
    /// <summary>
    /// Модуль повинен бути відкритий для розширення, але закритий для зміни
    /// Основна ідея цього принципу це розробка стійкої до змін програми.
    /// Закладення такої архітектури, щоб не велика зміна в класі не зачіпала зв'зані  з ним модулі  
    /// </summary>
    public class Logger
    {
        private IMessageLogger _messageLogger;

        public Logger(IMessageLogger messageLogger)
        {
            _messageLogger = messageLogger;
        }

        public void Log(string message)
        {
            _messageLogger.Log(message);
        }
    }

    public interface IMessageLogger
    {
        void Log(string message);
    }

    public class ConsoleLogger : IMessageLogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class FileLogger : IMessageLogger
    {
        public void Log(string message)
        {
            using (FileStream fs = new FileStream("file.txt", FileMode.OpenOrCreate))
            {
                byte[] bytes = Encoding.UTF8.GetBytes(message);
                fs.WriteAsync(bytes, 0, bytes.Length);
            }
        }
    }
}
