using System;
using System.Linq;
using System.Collections.Generic;
namespace c_sharp_1
{
    class Program
    {
        public static void Main()
        {
            //лабораторна 7 варіант 8
            Console.WriteLine("please,input lenght of list:");
            int n =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            var list = new List<string>(n);
            for (int i =0;i<n;i++)
            {
                Console.WriteLine("please,write some string:");
                string el = Console.ReadLine();
                list.Add(el);
            }
            Console.WriteLine("Your list is:");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("Emount of strings whose lenghts equals to last");
            int count = 0;
            foreach(var item in list)
            {
                if ( item.Length == list[list.Count-1].Length  )
                {
                    count++;
                }
            }
            Console.WriteLine(count);








        }
    } 
}
