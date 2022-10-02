using System;
using System.Linq;
namespace c_sharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //лабораторна 5 варіант 32
            int m, n;
            Console.WriteLine("введите количество рядков:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов:");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m, n];
            var random = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j=0;j<n;j++)
                {
                    arr[i, j] = random.Next(0, 10);
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //2 - min      
            for (int i =0;i < m;i++)
            {
                int min = arr[i,0];
                for (int j = 0; j < n; j++)
                {
                    if (arr[i,j] < min)
                    {
                        min = arr[i,j];
                        
                    }
                }
                Console.WriteLine("Строка {0} :  минимальное значение значение {1}",i,min);
            }
            Console.WriteLine();
            //3 - max
            for (int i = 0; i < m; i++)
            {
                int max =int.MinValue ;
                for (int j = 0; j < n; j++)
                {     
                    if (arr[j, i] > max)
                    {
                        max = arr[j, i];

                    }                   
                }
                Console.WriteLine("Столб {0} :  максимальное значение значение {1}", i, max);

            }
            Console.WriteLine();

























        }
    }
}
