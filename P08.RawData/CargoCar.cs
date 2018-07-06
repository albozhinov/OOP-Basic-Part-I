using System;
using System.Collections.Generic;
using System.Text;



public class CargoCar
{
    //model, engine, cargo and a collection of exactly 4 tires

    public string model;
    public Engine engine;
    public Cargo cargo;
    public List<Tyre> tires;

    public CargoCar(string model, Engine engine, Cargo cargo, List<Tyre> tires)
    {
        this.model = model;
        this.engine = engine;
        this.cargo = cargo;
        this.tires = tires;
    }




}

