using System;
using System.Linq;
namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабораторна 6
            //1-e
            Console.WriteLine("запишіть ціле число :");
            int mission1 =Convert.ToInt32(Console.ReadLine());
            static void Method(int x) {
                string s = Convert.ToString(x);
                char[] str = s.ToCharArray();
                string a;
                Console.WriteLine("Ваше обернене число :");
                for (int i = str.Length - 1; i > -1; --i)
                {
                    a = Convert.ToString(str[i]);
                    Console.Write(a);

                }
                Console.WriteLine();
            }
            Method(mission1);

            //2-e
            Console.WriteLine("Введіть строку :");
            string mission2 = Console.ReadLine();
            static void Method2(string y){
                string s2 = y;
                char[] str2 = s2.ToCharArray();
                string b;
                Console.WriteLine("Ваша обернена строка :");
                for (int i = str2.Length - 1; i > -1; --i)
                {
                    b = Convert.ToString(str2[i]);
                    Console.Write(b);

                }
                Console.WriteLine();
            }
            Method2(mission2);
            //3-e
            Console.WriteLine("запишіть дробове число :");
            double mission3 = Convert.ToDouble(Console.ReadLine());
            static void Method3(double c){
                double num = c;
                double fraction = num % 1;
                num -= fraction;
                fraction *= 1000;
                fraction = Convert.ToInt32(fraction);
                string input = num.ToString();
                char[] charArray = input.ToCharArray();
                string input2 = fraction.ToString();
                char[] charArray2 = input2.ToCharArray();
                Array.Reverse(charArray);
                Array.Reverse(charArray2);
                string output = new string(charArray);
                string output2 = new string(charArray2);
                Console.WriteLine("ціла частина :" + num);
                Console.WriteLine("дробова частина :" + fraction);
                Console.WriteLine("обернене число з дробовою частиною :");
                Console.WriteLine(output + "," + output2);
                Console.WriteLine();
            }
            Method3(mission3);

            //4-e
            Console.WriteLine("напишіть строку з магічним знаком :");
            string mission4 = Console.ReadLine();
            static void Method4(string n)
            {
                string input3 = n;
                char[] charArray3 = input3.ToCharArray();
                Array.Reverse(charArray3);
                string output3 = new string(charArray3);
                Console.WriteLine("Ваша обернена строка :");
                Console.WriteLine(output3);
                Console.WriteLine();
            }
            Method4(mission4);


            //7-e
            int[] arr = new int[6] {2,5,9,13,61,11};
            static void Massive(int[] array)
            {
                string b;
                Console.WriteLine("Ваш обернений  масив :");
                for (int i = array.Length - 1; i > -1; --i)
                {
                    b = Convert.ToString(array[i]);
                    Console.Write(b+" ");

                }
                Console.WriteLine();
            }
            Massive(arr);
            //8-e
            Console.WriteLine("Enter new size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            Newsize(arr, n);

            static void Newsize(int[] array,int x)
            {
                Array.Resize(ref array, x);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }
            }














        }
    }
}
