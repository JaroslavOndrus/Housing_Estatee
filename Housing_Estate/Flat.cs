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
    }
}
