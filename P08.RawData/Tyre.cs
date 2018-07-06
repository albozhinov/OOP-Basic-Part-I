using System;
using System.Collections.Generic;
using System.Text;


public class Tyre
{
    //<Tire1Pressure> <Tire1Age>

    public double tyrePressure;
    public int tyreAge;
   
    public Tyre(string pressure, string age)
    {
        double press = double.Parse(pressure);
        int ages = int.Parse(age);

        this.tyrePressure = press;
        this.tyreAge = ages;
    }
}

