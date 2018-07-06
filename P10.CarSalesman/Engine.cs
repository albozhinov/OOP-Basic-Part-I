using System;
using System.Collections.Generic;
using System.Text;


class Engine
{
    //An Engine has model, power, displacement and efficiency. A Car’s weight and color and its Engine’s displacements and efficiency are optional. 
    private string model;
    private string power;
    private string displacement;
    private string efficiency;

    public string Model { get { return this.model; } }

    public string Power { get { return this.power; } }

    public string Displacement { get { return this.displacement; } }

    public string Efficiency { get { return this.efficiency; } }

    public Engine(string model, string power)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = "n/a";
    }
    public Engine(string model, string power, int displacement)        
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement.ToString();
        this.efficiency = "n/a";
    }
    public Engine(string model, string power, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = "n/a";
        this.efficiency = efficiency;
    }
    public Engine(string model, string power, int displacement, string efficiency)
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement.ToString();
        this.efficiency = efficiency;
    }



}
