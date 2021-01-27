using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Hedgehog(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("* Hedgehog * Hedgehog *");
        }


        public override string Stats()
        {
            return base.Stats() + ". nrOfSpikes: " + NrOfSpikes;
        }
    }
}
