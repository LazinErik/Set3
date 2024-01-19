using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set3ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k, gasit=0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                if (v[i] == k)
                {
                    Console.WriteLine($"Numarul {k} apare pe pozitia {i} in vector");
                    gasit = 1;
                    break;
                }
            }
            if (gasit == 0) Console.WriteLine("-1");
        }
    }
}
