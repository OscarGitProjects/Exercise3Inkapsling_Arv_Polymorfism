using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Horse : Animal
    {
        public string HorseStuff { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Horse(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {
                
        }

        public override void DoSound()
        {
            Console.WriteLine("* Horse * Horse *");
        }


        public override string Stats()
        {
            return base.Stats() + ". HorseStuff: " + HorseStuff;
        }
    }
}
