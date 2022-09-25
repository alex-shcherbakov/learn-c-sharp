using System;

namespace C_sharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // мой номер в списке - 32, поэтому вариант 2-й
            //lab#1
            double r, u;
            Console.WriteLine("Enter value of tension : ");
            string str1 = Console.ReadLine();
            u = double.Parse(str1);
            Console.WriteLine("Enter value of resistance : ");
            string str2 = Console.ReadLine();
            r = double.Parse(str2);


            if (r > 0)
            {
                Console.WriteLine("your answer is :");
                Console.WriteLine("u = " + u);
                Console.WriteLine("r = " + r);
                Console.WriteLine("i = " + u / r);



            }
            else if (r == 1)
            {
                Console.WriteLine("your answer is :");
                Console.WriteLine(" u = " + u);
                Console.WriteLine(" r =  " + r);
                Console.WriteLine(" i = " + u);
            }
            else
            {
                Console.WriteLine(" you entered incorrect data");
            };
            // lab#2
            double n, nn, nk;
               
                Console.WriteLine("Enter value of n ");
                string str3 = Console.ReadLine();
                n = double.Parse(str3);
                Console.WriteLine("Enter value of k  ");
                string str4 = Console.ReadLine();
                nn = double.Parse(str4);
                Console.WriteLine("n is " + n);
                Console.WriteLine("k is " + nn);
                Console.WriteLine("nk is " + (nn + n));


                Console.WriteLine("result is  " + (Math.Pow(nn, 2) + Math.Pow(-1, nn) * (nn - 1)) / (Math.Pow(nn, 2) + 1));
            





        }
    }
}
