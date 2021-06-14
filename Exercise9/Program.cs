using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            A[] v = new A[3] { 
                new A() {N = 3, S = "hello" },
                new A() {N = 1, S = "world" },
                new A() {N = 2, S = "day" }
            };

            Array.Sort(v);
            foreach (var item in v)
            {
                Console.WriteLine($"{item.N} , {item.S}");
            }


        }
    }
}
