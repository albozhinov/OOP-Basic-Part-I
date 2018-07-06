using System;
using System.Collections.Generic;
using System.Linq;

namespace P10.CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> allEngines = JoinEngines(n);
            
            var m = int.Parse(Console.ReadLine());
            List<Car> allCars = JoinCars(m, allEngines);



            foreach (var car in allCars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }

        }

        public static List<Car> JoinCars(int m, List<Engine> allengines)
        {
            List<Car> cars = new List<Car>();
            for (int i = 0; i < m; i++)
            {
                //“<Model> <Engine> <Weight> <Color>
                var inputCars = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = inputCars[0];
                var engine = allengines.First(e => e.Model == inputCars[1]);
                Car currCar = null;


                if (inputCars.Length == 4)
                {
                    var weight = int.Parse(inputCars[2]);
                    var color = inputCars[3];
                    currCar = new Car(model, engine, weight, color);
                }
                else if (inputCars.Length == 2)
                {
                    currCar = new Car(model, engine);
                    cars.Add(currCar);
                    continue;
                }
                else
                {
                    try
                    {
                        var weight = int.Parse(inputCars[2]);
                        currCar = new Car(model, engine, weight);
                    }
                    catch (Exception)
                    {
                        var color = inputCars[2];
                        currCar = new Car(model, engine, color);                        
                    }
                }
                cars.Add(currCar);
            }
            return cars;
        }

        public static List<Engine> JoinEngines(int n)
        {
            List<Engine> currEngines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                //“<Model> <Power> <Displacement> <Efficiency>”
                var engineInput = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var model = engineInput[0];
                var power = engineInput[1];
                Engine currEngine = null;

                if (engineInput.Length == 4)
                {
                    var displacement = int.Parse(engineInput[2]);
                    var efficiency = engineInput[3];

                    currEngine = new Engine(model, power, displacement, efficiency);
                }
                else if (engineInput.Length == 2)
                {
                    currEngine = new Engine(model, power);
                    currEngines.Add(currEngine);
                    continue;
                }
                else
                {
                    try
                    {
                        int displacement = int.Parse(engineInput[2]);
                        currEngine = new Engine(model, power, displacement);
                    }
                    catch (Exception)
                    {
                        var efficiency = engineInput[2];
                        currEngine = new Engine(model, power, efficiency);
                    }
                }
                currEngines.Add(currEngine);
            }
            return currEngines;
        }
    }
}
