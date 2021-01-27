namespace Exercise3Inkapsling_Arv_Polymorfism.Djur
{
    public abstract class Animal
    {
        public string Namn { get; set; }
        public double Vikt { get; set; }
        public int Alder { get; set; }

        public abstract void DoSound();


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strNamn">Namn</param>
        /// <param name="dblVikt">Vikt</param>
        /// <param name="iAlder">Ålder</param>
        public Animal(string strNamn, double dblVikt, int iAlder)
        {
            Namn = strNamn;
            Vikt = dblVikt;
            Alder = iAlder;
        }

        public virtual string Stats()
        {
            return $"{Namn} är {Alder} år och väger {Vikt}";
        }
    }
}