using System;
using System.Collections.Generic;
using System.Text;


public class Engine
{
    //<EngineSpeed> <EnginePower> 
    public int engineSpeed;
    public int enginePower;

    public Engine(string speed, string power)
    {
        int spd = int.Parse(speed);
        int pwr = int.Parse(power);

        this.engineSpeed = spd;
        this.enginePower = pwr;
    }

}

