using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Square
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number =>");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>0&&a<=10)
            {
                int res = 1;
                for (int i = 0; i < a; i++)
                {
                    Console.Write("{0},", res);
                    res = res << 1;
                    
                }
            }
            Console.ReadKey();
        }
    }
}
