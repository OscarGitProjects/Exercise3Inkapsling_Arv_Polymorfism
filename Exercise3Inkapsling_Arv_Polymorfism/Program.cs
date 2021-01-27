using System;

namespace Exercise3Inkapsling_Arv_Polymorfism
{
    /// <summary>
    /// Svar på frågot
    /// Del 1. Kommer du direkt åt variablerna: Nej. Variablerna är private. Man komer åt dom genom dess properties
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            program.Run_CreatePersonWithPersonHandler();

            //program.Run_CreatePerson();

            Console.ReadLine();
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
