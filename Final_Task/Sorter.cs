using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Task
{
    public class Sorter
    {
        public static List<Animal> AnimalsFileSorter(string path)
        {
            string[] unsortedAnimals = File.ReadAllLines(path);
            List<Animal> sortedAnimals = new List<Animal>();
            string[,] animals = new string[unsortedAnimals.Length / 4, 4];
            for (int i = 0, lineCounter = 0; lineCounter < unsortedAnimals.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    animals[i, j] = unsortedAnimals[lineCounter++];
                }
            }
            for (int i = 0; i < animals.GetLength(0); i++)
            {
                double height;
                if (Double.TryParse(animals[i, 3].Split(' ').Skip(1).First(), out height))
                {
                    sortedAnimals.Add(new Donkey(animals[i, 0].Split(' ').Skip(1).Aggregate((current, next) => current + " " + next),
                                                    Convert.ToInt32(animals[i, 1].Split(' ').LastOrDefault()),
                                                    animals[i, 2].Split(' ').Skip(1).Aggregate((current, next) => current + " " + next),
                                                    height));
                }
                else
                {
                    sortedAnimals.Add(new Horse(animals[i, 0].Split(' ').Skip(1).Aggregate((current, next) => current + " " + next),
                                                    Convert.ToInt32(animals[i, 1].Split(' ').LastOrDefault()),
                                                    animals[i, 2].Split(' ').Skip(1).Aggregate((current, next) => current + " " + next),
                                                    animals[i, 3].Split(' ').Skip(1).Aggregate((current, next) => current + " " + next)));
                }
            }
            return sortedAnimals;
        }

        public static List<Horse> WhiteHorses(List<Animal> animals)
        {
            List<Horse> horses = new List<Horse>();
            foreach (var animal in animals)
            {
                if (animal is Horse)
                {
                    horses.Add(animal as Horse);
                }
            }
            List<Horse> whiteHorses = new List<Horse>();
            foreach (var horse in horses)
            {
                if (horse.Suit == "White")
                {
                    whiteHorses.Add(horse);
                }
            }
            return whiteHorses;
        }

        public static List<Donkey> DonkeysLowerThan(List<Animal> animals, double lowerThan)
        {
            List<Donkey> donkeys = new List<Donkey>();
            foreach (var animal in animals)
            {
                if (animal is Donkey)
                {
                    donkeys.Add(animal as Donkey);
                }
            }
            List<Donkey> sortedDonkeys = new List<Donkey>();
            foreach (var donkey in donkeys)
            {
                if (donkey.Height < lowerThan)
                {
                    sortedDonkeys.Add(donkey);
                }
            }
            return sortedDonkeys;
        }



    }
}
