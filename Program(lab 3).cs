using System;

namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабораторна 3 варіант 11
            Console.WriteLine("Enter 4-digit number :");
            string s = Console.ReadLine();
            char[] str = s.ToCharArray();
            string a;
            Console.WriteLine("your reversed number is:");
            for(int i = str.Length - 1; i > -1; --i)
            {
                a = Convert.ToString(str[i]);
                Console.Write(a);

            }
            if (s.Length > 3 )
            {
                Console.WriteLine();
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("not 4-digit number ");
            }






















        }
    }
}
