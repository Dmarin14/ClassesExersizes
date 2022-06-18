using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CarLot = new List<Car>();

            Car car1 = new Car();
            car1.Make = "Toyota";
            car1.Model = "Tacoma";
            car1.Year = 2020;
            car1.EngineNoise = "rrrrrr";
            car1.HonkNoise = "honk";
            car1.IsDriveable = true;
            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            CarLot.Add(car1);
            

            Car car2 = new Car() { Make = "Tesla", Model = "Model 3", Year = 2022, EngineNoise = "None", HonkNoise = "Custom Honk", IsDriveable = true };
            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            CarLot.Add(car2);

            Car car3 = new Car()
            {
                Make = "Ford",
                Model = "Ranger",
                Year = 2023,
                EngineNoise = "rrrrrr",
                HonkNoise = "honk",
                IsDriveable = true,
            };
            car3.MakeEngineNoise();
            car3.MakeHonkNoise();

            CarLot.Add(car3);

            Console.WriteLine("--------------------------");

            foreach (Car car in CarLot)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year} {car.EngineNoise} {car.HonkNoise} {car.IsDriveable}");
            }

            Console.ReadLine();
        }

    }
}
