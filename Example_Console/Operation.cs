using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_Console
{
    internal class Operation
    {
        int result;
        public int sum(int x, int y)
        {
            result = x + y;
            Console.WriteLine(result);
           return result;
            
        }

        public int subtraction(int x, int y)
        {
            if (x >= y)
            {
                result = x - y;
            }
            else
            {
                result = y - x;
            }
            Console.WriteLine(result);
            return result;
        }

        public int divide(int x, int y)
        {
            if (x >= y)
            {
                result = x / y;

            }
            else
            {
                result = y / x;
            }
            Console.WriteLine(result);
            return result;
        }

        public int multiplication (int x, int y)
        {
            result = x * y;
            Console.WriteLine(result);
            return result;
        }
    }
}
