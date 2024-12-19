using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Task
{
    [JsonObject]
    [Serializable]
    public class Donkey : Animal
    {
        private string _species;
        private double _height;

        [JsonProperty]
        [XmlAttribute]
        public string Species
        {
            get { return _species; }
            set { _species = value; }
        }

        [JsonProperty]
        [XmlAttribute]
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public Donkey(string name, int birthYear, string species, double height) : base(name, birthYear)
        {
            _species = species;
            _height = height;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Donkey name: {this.AnimalName}\n\tBirth year: {this.BirthYear}\n\tSpecies: {this.Species}\n\tHeight: {this.Height} metres");
        }

        public override string ToString()
        {
            return $"Donkey name: {this.AnimalName}\n\tBirth year: {this.BirthYear}\n\tSpecies: {this.Species}\n\tHeight: {this.Height} metres";
        }
    }
}
