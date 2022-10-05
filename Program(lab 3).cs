using System;

namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3-я лабораторная 11-й вариант
            Console.WriteLine("запишіть 4-х значне число :");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string output = new string(charArray);
            if (input.Length > 3)
            {
                Console.WriteLine("обернене число :");
                Console.WriteLine(output);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(" Ви ввели не 4-х значне число");
                Console.WriteLine();
            }
            if (input == output)
            {
                Console.WriteLine("Вказані числа однакові");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Числа не однакові");
                Console.WriteLine();
            }






















        }
    }
}
