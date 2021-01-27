using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Wolf : Animal
    {
        public string WolfStuff { get; set; }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Wolf(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }

        public override void DoSound()
        {
            Console.WriteLine("* Wolf * Wolf *");
        }

        public override string Stats()
        {
            return base.Stats() + ". WolfStuff: " + WolfStuff;
        }
    }
}
