using System;
using System.Collections.Generic;

namespace Housing_Estate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Person person = new Person("Jaro", "Ondruš", 4);
            Console.WriteLine(person.ToString());*/

            Person person = new Person("Jaro", "Ondruš", 16);

            Console.WriteLine();

            

            Flat flat = new Flat(14, 58.6, 5, new List<Person>() {person});
            Console.WriteLine(flat.ToString());

            int addPokracovanie = 0;
            while (addPokracovanie != 4) 
            {
                Console.WriteLine("\t [1] PRIDAT OBYVATELA ");
                Console.WriteLine("\t [2] VYPISAT OBYVATELOV ");
                Console.WriteLine("\t [3] VYTVORIT BYT ");
                Console.WriteLine("\t [4] UKONCIT PRIDAVANIE OBYVATELA");
                int addVyber = Int32.Parse(Console.ReadLine());

                switch (addVyber)
                {
                    case 1:
                        Console.WriteLine("ZADAJ MENO: ");
                        string meno = Console.ReadLine();
                        Console.WriteLine("ZADAJ PRIEZVISKO: ");
                        string priezvisko = Console.ReadLine();
                        Console.WriteLine("ZADAJ VEK: ");
                        int vek = Int32.Parse(Console.ReadLine());

                        flat.AddHabitant(meno, priezvisko, vek);
                        break;

                    case 2:
                        flat.GetInfoAboutAllHabitants();
                        break;

                    default:
                        addPokracovanie = 4;
                        break;
                }
                    
            }
        }
    }
}
