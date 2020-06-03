using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość argumentów: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci.fibo(a));

            Console.ReadKey();
        }
    }
}
