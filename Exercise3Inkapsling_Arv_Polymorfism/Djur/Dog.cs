using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Dog : Animal
    {
        public string  DogStuff { get; set; }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Dog(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }

        public override void DoSound()
        {
            Console.WriteLine("* Dog * Dog *");
        }


        public override string Stats()
        {
            return base.Stats() + ". DogStuff: " + DogStuff;
        }
    }
}
