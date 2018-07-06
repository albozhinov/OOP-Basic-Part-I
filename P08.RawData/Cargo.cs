using System;
using System.Collections.Generic;
using System.Text;


public class Cargo
{
    //CargoWeight> <CargoType> 
    public int cargoWeight;
    public string cargoType;

    public Cargo(string weight, string type)
    {
        int wght = int.Parse(weight);

        this.cargoWeight = wght;
        this.cargoType = type;
    }

}

