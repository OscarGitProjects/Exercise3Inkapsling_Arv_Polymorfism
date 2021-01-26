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
            program.Run();

            Console.ReadLine();
        }

        private void Run()
        {
            Console.WriteLine("Run porgram!");

            Person person = new Person("Kalle", "Andersson");
            person.Age = 33;
            person.Height = 175.5;
            person.Weight = 83.5;

            Console.WriteLine(person);
        }
    }
}
