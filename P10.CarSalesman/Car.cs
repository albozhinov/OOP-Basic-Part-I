using System;
using System.Collections.Generic;
using System.Text;


class Car
{
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public string Model { get { return this.model; } }

    public Engine Engine { get { return this.engine; } }

    public string Weight { get { return this.weight; } }

    public string Color { get { return this.color; } }

    
    public Car(string model, Engine engine)        
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = "n/a";
    }
    public Car(string model, Engine engine, int weight)        
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight.ToString();
        this.color = "n/a";
    }
    public Car(string model, Engine engine, string color)
    {
        this.model = model;
        this.engine = engine;
        this.weight = "n/a";
        this.color = color;
    }

    public Car(string model, Engine engine, int weight, string color)       
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight.ToString();
        this.color = color;
    }



}

