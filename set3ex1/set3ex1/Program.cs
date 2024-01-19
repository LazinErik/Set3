using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0;
            Console.Write("n = ");
            n= int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                suma = suma + v[i];
            }
            Console.WriteLine($"Suma elementelor vectorului este: {suma}");
        }
    }
}
