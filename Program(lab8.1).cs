using System;
using System.Linq;
using System.Collections.Generic;
namespace c_sharp_1
{
    public class Cars
    {
        public string Name { get; }
        public string Color { get; }
        public string Speed { get; }


        public Cars(string name, string color, string speed)
        {
            Name = name;
            Color = color;
            Speed = speed;
        }

        public void Data_Of_Car()
        {
            Console.WriteLine(
                $"NAME: {Name} --- COLOR: {Color} --- SPEED: {Speed}");
        }
    }
    public class SheihGarage
    {
        public List<Cars> Cars { get; } = new();

        public void AddCar(Cars car)
        {
            Cars.Add(car);
        }

        public void RemoveCar(Cars car)
        {
            Cars.Remove(car);
        }

        public void ShowAutoPark()
        {
            Console.WriteLine("Your car park:");
            for (int i = 0; i < Cars.Count; i++)
            {
                Console.WriteLine($"Car index - {i}");
                Cars[i].Data_Of_Car();
            }
        }


    }
    class Program
    {
        public static void Main()
        {
            var garage = new SheihGarage();
            garage.ShowAutoPark();

            Console.WriteLine("Do you want to buy or delete one of the cars?");
            Console.WriteLine("Buy - 0");
            Console.WriteLine("Delete - 1");
            int decision = int.Parse(Console.ReadLine());
            if(decision == 0)
            {
                    BuyCar(garage);                
            }
            else if(decision == 1) {
                    Delete(garage);
            }
            else
            {
                Console.WriteLine("not right number");
            }
            
        }

        private static void BuyCar(SheihGarage garage)
        {
            Console.WriteLine("Enter car brand");
            string Name = Console.ReadLine();

            Console.WriteLine("Enter car color");
            string Color = Console.ReadLine();

            Console.WriteLine("Enter car speed");
            string Speed = Console.ReadLine();

            var newCar = new Cars(Name,Color,Speed);
            garage.AddCar(newCar);
            garage.ShowAutoPark();
        }

        private static void Delete(SheihGarage garage)
        {
            Console.WriteLine("Which car to delete?");
            int carIndex = int.Parse(Console.ReadLine());
            garage.RemoveCar(garage.Cars[carIndex]);
            garage.ShowAutoPark();
        }   
}
    }


