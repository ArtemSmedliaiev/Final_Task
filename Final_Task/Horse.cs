using Final_Task;
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
    public class Horse : Animal
    {
        private string _suit;
        private string _breed;

        [JsonProperty]
        [XmlAttribute]
        public string Suit
        {
            get { return _suit; }
            set { _suit = value; }
        }

        [JsonProperty]
        [XmlAttribute]
        public string Breed
        {
            get { return _breed; }
            set { _breed = value; }
        }

        public Horse(string name, int birthYear, string suit, string breed) : base(name, birthYear)
        {
            _suit = suit;
            _breed = breed;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Horse name: {this.AnimalName}\n\tBirth year: {this.BirthYear}\n\tSuit: {this.Suit}\n\tBreed: {this.Breed}");
        }

        public override string ToString()
        {
            return $"Horse name: {this.AnimalName}\n\tBirth year: {this.BirthYear}\n\tSuit: {this.Suit}\n\tBreed: {this.Breed}";
        }
    }
}
