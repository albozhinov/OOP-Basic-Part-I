using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            List<Car> myCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carsInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = carsInfo[0];
                var fuelAmount = double.Parse(carsInfo[1]);
                var fuelConsumption = double.Parse(carsInfo[2]);

                Car currCar = new Car(model, fuelAmount, fuelConsumption);

                if (myCars.Any(c => c.Model == model))
                {
                    continue;
                }

                myCars.Add(currCar);
            }

            var inputLine = "";
            while (true)
            {
                inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    break;
                }
                var commands = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (commands[0] == "Drive")
                {
                    var currCar = myCars.First(c => c.Model == commands[1]);
                    currCar.Drive(commands[2]);
                }
            }
            foreach (var car in myCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.DistanceTraveled}");
            }

        }
    }
}
