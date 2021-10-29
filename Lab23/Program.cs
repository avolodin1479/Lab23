using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            Factorial();
            Console.ReadKey();
        }
        static void Factorial()
        {
            int n = 65;
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.Write("{0}!={1}", n, fact);
        }
        static async Task FactorialAsync()
        {
            await Task.Run(() => Factorial());
        }
    }
}
