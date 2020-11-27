using System;

namespace Housing_Estate
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Jaro", "Ondruš", 4);
            Console.WriteLine(person.ToString());
        }
    }
}
