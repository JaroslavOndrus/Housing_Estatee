using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Flat
    {
        public int NumberOfFlat { get; set; }
        public double Area { get; set; }
        public int NumberOfRooms { get; set; }
        public List<Person> person = new List<Person>();

        public Flat(int numberOfFlat, double area, int numberOfRooms, List<Person> person)
        {
            NumberOfFlat = numberOfFlat;
            Area = area;
            NumberOfRooms = numberOfRooms;
            this.person = person;
        }

        public override string ToString()
        {
            return ($"CISLO BYTU : {NumberOfFlat}\nROZLOHA : {Area}\nPOCET IZIEB : {NumberOfRooms}");
        }

        public void AddHabitant(string nameOfHabitat, string surNameOfHabitant, int ageOfHabitant)
        {
            Person habitant = new Person(nameOfHabitat, surNameOfHabitant, ageOfHabitant);
            person.Add(habitant);
        }

        public void GetInfoAboutAllHabitants()
        {
            for (int i = 0; i < person.Count; i++)
            {
                Console.WriteLine($"{person[i]}\n");
            }
        }
    }
}
