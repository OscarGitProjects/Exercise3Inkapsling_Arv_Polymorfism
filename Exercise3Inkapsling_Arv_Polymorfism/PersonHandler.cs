using System;

namespace Exercise3Inkapsling_Arv_Polymorfism
{
    public class PersonHandler
    {
        /// <summary>
        /// Metoden sätter age i Person objektet
        /// </summary>
        /// <param name="person">Person objekt som skall uppdateras</param>
        /// <param name="iAge">Nya ålderna</param>
        /// <exception cref="System.ArgumentNullException">Kastas om referensen till Person är null</exception>
        /// <exception cref="System.ArgumentException">Kastas om ålder är 0 eller mindre</exception>
        public void SetAge(Person person, int iAge)
        {
            if (person == null)
                throw new ArgumentNullException("PersonHandler-> SetAge(). Person referensen är null");

            if(iAge <= 0)
                throw new ArgumentException("PersonHandler-> SetAge(). Ålder måste vara större än 0");

            person.Age = iAge;
        }
    }
}
