using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
{
    abstract class Class1
    {
        int x;
        public abstract void f(int n);
        private void G(uint n)
        {
            x = n as int;
            /*
             * The as operator is used to perform conversion between compatible reference types or Nullable types. 
             * This operator returns the object when they are compatible with the given type and return null 
             * if the conversion is not possible instead of raising an exception. 
             */
        }
        public string ToString()
        {
            return x.ToString();
        }
    }
}
