using System;

class Car
{
    //model, fuel amount, fuel consumption for 1, distance traveled
    private string model;
    private double fuelAmount;
    private double fuelConsumption;
    private int distanceTraveled;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelConsumption
    {
        get { return this.fuelConsumption; }
        set { this.fuelConsumption = value; }
    }

    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.fuelConsumption = fuelConsumption;
        this.distanceTraveled = 0;
    }

    public void Drive(string amountOfKm)
    {
        var km = int.Parse(amountOfKm);
        
        var fuel = km * this.FuelConsumption;

        if (fuel > this.FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        else
        {
            this.FuelAmount -= fuel;
            this.DistanceTraveled += km;
        }
    }

}

