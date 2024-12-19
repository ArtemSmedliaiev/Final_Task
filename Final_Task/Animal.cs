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
    public abstract class Animal
    {
        private string _animalName;
        private int _birthYear;

        [JsonProperty]
        [XmlAttribute]
        public string AnimalName
        {
            get { return _animalName; }
            set { _animalName = value; }
        }
        [JsonProperty]
        [XmlAttribute]
        public int BirthYear
        {
            get { return _birthYear; }
            set { _birthYear = value; }
        }

        public Animal(string name, int birthYear)
        {
            _animalName = name;
            _birthYear = birthYear;
        }

        public abstract void PrintInfo();
    }
}
