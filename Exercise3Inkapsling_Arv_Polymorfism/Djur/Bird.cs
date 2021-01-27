using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Bird : Animal
    {
        public int WingSpan { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Bird(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }
        public override void DoSound()
        {
            Console.WriteLine("* Bird * Bird *");
        }

        public override string Stats()
        {
            return base.Stats() + ". WingSpan: " + WingSpan;
        }
    }
}
