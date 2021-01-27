using Exercise3Inkapsling_Arv_Polymorfism.Djur;
using System;
using System.Collections.Generic;

namespace Exercise3Inkapsling_Arv_Polymorfism
{
    /// <summary>
    /// Svar på frågor
    /// Del 1. Kommer du direkt åt variablerna: Nej. Variablerna är private. Man komer åt dom genom dess properties
    /// 
    /// 3.2. Arv.
    /// Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?   I klassen Bird
    /// 
    /// Om alla djur behöver det nya attributet, vart skulle man lägga det då?  I basklassen Animal
    /// 
    /// 3.3. Polymorfism.
    /// Försök att lägga till en häst i listan av hundar. Varför fungerar inte det? För att det inte går att automatiskt casta Horse objektet till ett Dog objekt. Det går bara casta uppåt i klass hierarkin
    /// 
    /// Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?   En lista av basklassen Animal
    /// 
    /// Förklara vad det är som händer. Vi anropar den första Stats metoden som finns i klass hierarkin. dvs. i bland kan det bli den som finns i basklassen Animal
    /// 
    /// Kommer du åt den metoden från Animals listan?   Nej
    /// Varför inte?    För att man inte automatiskt kan casta från basklassen ner till subklassen dog. Man kan göra Dog dog = (Dog)animal
    /// 
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Run_ShowListWithAnimalsStatsForDogs();

            // program.Run_ShowListWithHundar();

            //program.Run_ShowListWithAnimals();

            //program.Run_CreatePersonWithPersonHandler();

            //program.Run_CreatePerson();

            Console.ReadLine();
        }


        /// <summary>
        /// Metoden skapar en lista med olika Animal
        /// Skriver sedan ut Stats för objekt av klassen Dog
        /// </summary>
        private void Run_ShowListWithAnimalsStatsForDogs()
        {
            IList<Animal> lsAnimals = new List<Animal>();

            Dog dog1 = new Dog("Hund 1", 1.5, 1);
            dog1.DogStuff = "Jag är hund 1";
            
            Dog dog2 = new Dog("Hund 2", 2.5, 2);
            dog2.DogStuff = "Jag är hund 2";

            lsAnimals.Add(dog1);
            lsAnimals.Add(dog2);

            lsAnimals.Add(new Horse("Horse 1", 1.5, 1));
            lsAnimals.Add(new Horse("Horse 2", 2.5, 2));

            lsAnimals.Add(new Bird("Bird 1", 1.5, 1));
            lsAnimals.Add(new Bird("Bird 2", 2.5, 2));

            lsAnimals.Add(new Flamingo("Flamingo 1", 1.5, 1));
            lsAnimals.Add(new Flamingo("Flamingo 2", 2.5, 2));

            lsAnimals.Add(new Worm("Worm 1", 1.5, 1));
            lsAnimals.Add(new Worm("Worm 2", 2.5, 2));

            lsAnimals.Add(new Wolf("Wolf 1", 1.5, 1));
            lsAnimals.Add(new Wolf("Wolf 2", 2.5, 2));

            lsAnimals.Add(new Wolfman("WolfMan 1", 1.5, 1));
            lsAnimals.Add(new Wolfman("WolfMan 2", 2.5, 2));

            foreach (Animal animal in lsAnimals)
            {
                if (animal is Dog dog)
                {
                    Console.Write(dog.Stats() + ", " + dog.DogStuff);
                    dog.DoSound();
                }
            }
        }


        /// <summary>
        /// Metoden skapar en lista med hundar
        /// Skriver ut info om dessa i konsolen
        /// </summary>
        private void Run_ShowListWithHundar()
        {
            IList<Dog> lsAnimals = new List<Dog>();
            lsAnimals.Add(new Dog("Hund 1", 1.5, 1));
            lsAnimals.Add(new Dog("Hund 2", 2.5, 2));

            foreach (Animal animal in lsAnimals)
            {
                Console.Write(animal.Stats() + " ");
                animal.DoSound();
            }
        }


        /// <summary>
        /// Metoden skapar en lista med olika Animal
        /// Skriver sedan ut info om dessa i konsolen
        /// </summary>
        private void Run_ShowListWithAnimals()
        {
            IList<Animal> lsAnimals = new List<Animal>();

            lsAnimals.Add(new Dog ("Hund 1", 1.5, 1));
            lsAnimals.Add(new Dog("Hund 2", 2.5, 2));

            lsAnimals.Add(new Horse("Horse 1", 1.5, 1));
            lsAnimals.Add(new Horse("Horse 2", 2.5, 2));

            lsAnimals.Add(new Bird("Bird 1", 1.5, 1));
            lsAnimals.Add(new Bird("Bird 2", 2.5, 2));

            lsAnimals.Add(new Flamingo("Flamingo 1", 1.5, 1));
            lsAnimals.Add(new Flamingo("Flamingo 2", 2.5, 2));

            lsAnimals.Add(new Worm("Worm 1", 1.5, 1));
            lsAnimals.Add(new Worm("Worm 2", 2.5, 2));

            lsAnimals.Add(new Wolf("Wolf 1", 1.5, 1));
            lsAnimals.Add(new Wolf("Wolf 2", 2.5, 2));

            lsAnimals.Add(new Wolfman("WolfMan 1", 1.5, 1));
            lsAnimals.Add(new Wolfman("WolfMan 2", 2.5, 2));

            foreach (Animal animal in lsAnimals)
            {
                Console.Write(animal.Stats() + " ");

                if (animal is IPerson pers)
                    pers.Talk();

                animal.DoSound();
            }
        }


        /// <summary>
        /// Metoden skapar en person med PersonHandler
        /// </summary>
        private void Run_CreatePersonWithPersonHandler()
        {
            Console.WriteLine("Run_CreatePersonWithPersonHandler!");

            PersonHandler personHandler = new PersonHandler();
            Person newPerson = null;

            try
            {
                newPerson = personHandler.CreatePerson(33, "Sture", "Stelben", 178.5, 78.5);

                Console.WriteLine(newPerson);
            }
            catch (Exception exc)
            {
                Console.WriteLine("Exception: " + exc);
            }
        }


        /// <summary>
        /// Metoden skapar ett Person objekt med new
        /// </summary>
        private void Run_CreatePerson()
        {
            Console.WriteLine("Run_CreatePerson!");

            Person person = null;

            try
            {
                person = new Person("Kalle", "Andersson");
                person.Age = 33;
                person.Height = 175.5;
                person.Weight = 83.5;

                Console.WriteLine(person);
            }
            catch(Exception exc)
            {
                Console.WriteLine("Exception: " + exc);
            }            
        }
    }
}
