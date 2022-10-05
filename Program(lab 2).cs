using System;

namespace C_sharp2
{
    //екземпляр класу
    //get,set
    //public,private
    //конструктор 
    //властивість 
   
   class Program
    {

        static void Main(string[] args)
        {
            // лабораторна №2 варіант 2 
            double n, nn;
               
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
