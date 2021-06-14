using System;

namespace Exercise4
{
    class A
    {
        static int n = 1;
        public void f()
        {
            n++;
        }

        public void Report()
        {
            Console.WriteLine(n.ToString());
        }

    }

    class MainClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            A x = new A();
            A y = new A();
            x.f();
            x.Report();
            y.f();
            y.Report();
        }

        /*
         * A static variable is declared with the help of static keyword. 
         * When a variable is declared as static, then a single copy of the variable is created 
         * and shared among all objects at the class level. Static variables are accessed
         * with the name of the class, they do not require any object for access.
         */
    }
}
