using System;

namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Wolfman : Wolf, IPerson
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Wolfman(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }


        public void Talk()
        {
            Console.WriteLine("I am Wolfman!!");
        }
    }
}
