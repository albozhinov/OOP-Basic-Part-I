using System;
using System.Linq;
using System.Collections.Generic;

namespace P11.PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainer> allTrainers = GetAllTrainers();

            CheckAllPokemons(allTrainers);
            
            
            foreach (var trainer in allTrainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
            }
        }

        private static void CheckAllPokemons(List<Trainer> allTrainers)
        {
            while (true)
            {
                var elements = Console.ReadLine();

                if (elements == "End")
                {
                    break;
                }

                List<Trainer> trainers = allTrainers.Where(t => t.Pokemons.Any(p => p.Element == elements)).ToList();

                foreach (var trainer in trainers)
                {
                    trainer.Badges++;
                }

                List<Trainer> pokemonsWithoutElement = allTrainers.Where(t => t.Pokemons.Any(p => p.Element != elements)).ToList();

                foreach (var trainer in pokemonsWithoutElement)
                {
                    if (trainers.Contains(trainer))
                    {
                        continue;
                    }
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                    trainer.RemoveDeadPokemons();
                }
            }
        }

        private static List<Trainer> GetAllTrainers()
        {
            List<Trainer> allTrainers = new List<Trainer>();
            while (true)
            {
                //“<TrainerName> <PokemonName> <PokemonElement> <PokemonHealth>”
                var inputLine = Console.ReadLine();

                if (inputLine == "Tournament")
                {
                    break;
                }
                var info = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var trainerName = info[0];
                var pokemonName = info[1];
                var pokemonElement = info[2];
                var pokemonHealth = int.Parse(info[3]);

                Trainer currTrainer = null;
                Pokemon currPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (allTrainers.Any(t => t.Name == trainerName))
                {
                    currTrainer = allTrainers.First(x => x.Name == trainerName);
                    currTrainer.Pokemons.Add(currPokemon);
                    continue;
                }
                else
                {
                    currTrainer = new Trainer(trainerName);
                    currTrainer.Pokemons.Add(currPokemon);
                    allTrainers.Add(currTrainer);
                }

            }
            return allTrainers;
        }


    }
}
