namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Pelican : Bird
    {
        public string PelicanStuff { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Pelican(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }

        public override string Stats()
        {
            return base.Stats() + ". PelicanStuff: " + PelicanStuff;
        }
    }
}
