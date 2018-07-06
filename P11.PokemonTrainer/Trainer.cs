using System;
using System.Collections.Generic;
using System.Linq;

class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public string Name { get { return this.name; } }

    public int Badges
    {
        get { return this.badges; }
        set { this.badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }
    public void RemoveDeadPokemons()
    {
        this.Pokemons = this.Pokemons.Where(p => p.Health > 0).ToList();
    }


}

