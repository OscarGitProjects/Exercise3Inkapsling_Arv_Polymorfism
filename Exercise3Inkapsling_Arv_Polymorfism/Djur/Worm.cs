using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Worm : Animal
    {
        public bool IsPoisonous { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Worm(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("* Worm * Worm *");
        }

        public override string Stats()
        {
            return base.Stats() + ". IsPoisonous: " + IsPoisonous;
        }
    }
}
