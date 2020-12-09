using System;
using System.Collections.Generic;
using System.Text;

namespace Housing_Estate
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public List<Flat> Flats { get; set; }

        public Person(string name, string surName, int age)
        {
            Name = name;
            SurName = surName;
            Age = age;
        }


        public override string ToString()
        {
            return ($"MENO : {Name}\nPRIEZVISKO : {SurName}\nVEK : {Age}");
        }
    }
}
