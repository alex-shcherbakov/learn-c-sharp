using System;
using System.Linq;
namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабораторна 4 варіант 32
            int SizeOfArr = Convert.ToInt32(Console.ReadLine());
            int[] values = new int[SizeOfArr];
            var random = new Random();
            for (int i = 0; i < SizeOfArr; i++)
            {
                values[SizeOfArr - 1] = random.Next(0, 30);
                Console.Write(values[SizeOfArr - 1] + " ");


            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("відсортований масив ");
            for (int i = SizeOfArr - 1; i >= 0; i--)
            {
                Console.Write(values[i] + " ");
            }




























        }
    }
}
