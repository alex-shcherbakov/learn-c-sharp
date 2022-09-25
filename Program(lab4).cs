using System;
using System.Linq;
namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабораторна 4 варіант 32
            int[] values = { 71, 85, 95, 18, 27,34 };
            var sorted = values.Select((e, i) => new { e, i }).OrderBy(e => e.e).ToArray();
            for (var i = 0; i < values.Length; i++)
            {
                Console.WriteLine($"{values[i]} [{i}] {sorted[i].e} [{sorted[i].i}]");
            }
            int[] values2 = { 314, 285, 595, 318, 227, 934 };
            var sorted2 = values2.Select((e, i) => new { e, i }).OrderByDescending(e => e.e).ToArray();
            for (var i = 0; i < values2.Length; i++)
            {
                Console.WriteLine($"{values2[i]} [{i}] {sorted2[i].e} [{sorted2[i].i}]");
            }





























        }
    }
}
