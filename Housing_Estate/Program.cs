using System;
using System.Collections.Generic;

namespace Housing_Estate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jaro", "Ondruš", 4);
            Console.WriteLine(person.ToString());

            Flat flat = new Flat(14, 58.6, 5, new List<Person>() {person});
            Console.WriteLine(flat.ToString());
        }
    }
}
