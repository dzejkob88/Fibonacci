using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Fibonacci
    {
        public static int fibo(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return fibo(n - 2) + fibo(n - 1);

        }
    }
}
