namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public class Swan : Bird
    {
        public string SwanStuff { get; set; }

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Swan(string strNamn, double dblVikt, int iAlder) : base(strNamn, dblVikt, iAlder)
        {

        }

        public override string Stats()
        {
            return base.Stats() + ". SwanStuff: " + SwanStuff;
        }
    }
}
