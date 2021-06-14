using System;

namespace Exercise5
{
    public class MyClass
    {
        public delegate void LogHandlerv(string message);
        public void Process(LogHandlerv logHandlerv)
        {
            if (logHandlerv != null)
            {
                logHandlerv("begin");
            }
            if (logHandlerv != null)
            {
                logHandlerv("End");
            }
        }
    }

    public class MyLogger
    {
        public void Logger(string s)
        {
            Console.WriteLine(s);
        }

    }
    public class TestApplication
    {
        static void Logger(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyLogger f1 = new MyLogger();
            MyClass myClass = new MyClass();
            MyClass.LogHandlerv myLogger = null;
            myLogger += new MyClass.LogHandlerv(Logger);
            myLogger += new MyClass.LogHandlerv(f1.Logger);
            myClass.Process(myLogger);
            return;
        }
    }
}
