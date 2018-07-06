using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<CargoCar> myCars = new List<CargoCar>();

            for (int i = 0; i < n; i++)
            {                
                var carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Engine curEngine = new Engine(carInfo[1], carInfo[2]);
                Cargo currCargo = new Cargo(carInfo[3], carInfo[4]);

                Tyre tyre1 = new Tyre(carInfo[5], carInfo[6]);
                Tyre tyre2 = new Tyre(carInfo[7], carInfo[8]);
                Tyre tyre3 = new Tyre(carInfo[9], carInfo[10]);
                Tyre tyre4 = new Tyre(carInfo[11], carInfo[12]);

                List<Tyre> currTires = new List<Tyre>() { tyre1, tyre2, tyre3, tyre4 };

                CargoCar currCar = new CargoCar(carInfo[0], curEngine, currCargo, currTires);

                myCars.Add(currCar);
            }
            var command = Console.ReadLine();

            if (command == "fragile")
            {
                myCars.Where(c => c.cargo.cargoType == "fragile")
                      .Where(x => x.tires
                      .Any(t => t.tyrePressure < 1))
                      .Select(m => m.model)
                      .ToList()
                      .ForEach(a => Console.WriteLine(a));
            }
            else
            {
                myCars.Where(c => c.cargo.cargoType == "flamable")
                      .Where(x => x.engine.enginePower > 250)
                      .Select(s => s.model)
                      .ToList()
                      .ForEach(a => Console.WriteLine(a));                
            }
        }
    }
}
