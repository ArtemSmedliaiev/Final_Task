using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.Globalization;

namespace Final_Task
{
    internal class Program
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            try
            {
                List<Animal> animals = Sorter.AnimalsFileSorter("Animals.txt");
                animals = animals.OrderBy(a => a.BirthYear).ToList();
                using (StreamWriter writer = new StreamWriter("birthYearSortedAnimals.txt"))
                {
                    foreach (var animal in animals)
                    {
                        writer.WriteLine(animal.ToString());
                    }
                }

                List<Horse> whiteHorses = Sorter.WhiteHorses(animals);
                List<Donkey> lowerDonkeys = Sorter.DonkeysLowerThan(animals, 1.5);

                using (StreamWriter writer = new StreamWriter("whiteHorsesLowerDonkeys.txt"))
                {
                    foreach (var horse in whiteHorses)
                    {
                        writer.WriteLine($"White horses count: {whiteHorses.Count}");
                        writer.WriteLine(horse.ToString());
                    }
                    foreach (var donkey in lowerDonkeys)
                    {
                        writer.WriteLine($"Donkeys lower than 1.5 count: {lowerDonkeys.Count}");
                        writer.WriteLine(donkey.ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
            Console.ReadKey();
        }

    }
}
