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






        }
    }
}
