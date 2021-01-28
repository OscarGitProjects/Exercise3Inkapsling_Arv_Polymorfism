using System;

namespace Exercise3Inkapsling_Arv_Polymorfism
{
    /// <summary>
    /// Klass med metoder för att skapa Person objekt och uppdatera värden i ett person objekt
    /// </summary>
    public class PersonHandler
    {
        /// <summary>
        /// Metoden sätter age i Person objektet
        /// Validering av indata sker i Person objektets set properties
        /// </summary>
        /// <param name="person">Person objekt som skall uppdateras</param>
        /// <param name="iAge">Nya ålderna</param>
        /// <exception cref="System.ArgumentNullException">Kastas om referensen till Person är null</exception>
        /// <exception cref="System.ArgumentException">Kastas om ålder är 0 eller mindre</exception>
        public void SetAge(Person person, int iAge)
        {
            if (person == null)
                throw new ArgumentNullException("PersonHandler->SetAge(). Person referensen är null");

            //if(iAge <= 0)
            //    throw new ArgumentException("PersonHandler->SetAge(). Ålder måste vara större än 0");

            try
            {
                person.Age = iAge;
            }
            catch(Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Metoden sätter height i Person objektet
        /// </summary>
        /// <param name="person">Person objektet som skall uppdateras</param>
        /// <param name="dblHeight">Nya längden</param>
        /// <exception cref="System.ArgumentNullException">Kastas om referensen till Person är null</exception>
        public void SetHeight(Person person, double dblHeight)
        {
            if (person == null)
                throw new ArgumentNullException("PersonHandler->SetHeight(). Person referensen är null");

            person.Height = dblHeight;
        }


        /// <summary>
        /// Metoden sätter weight i Person objektet
        /// </summary>
        /// <param name="person">Person objektet som skall uppdateras</param>
        /// <param name="dblWeight">Nya vikten</param>
        /// <exception cref="System.ArgumentNullException">Kastas om referensen till Person är null</exception>
        public void SetWeight(Person person, double dblWeight)
        {
            if (person == null)
                throw new ArgumentNullException("PersonHandler->SetWeight(). Person referensen är null");

            person.Weight = dblWeight;
        }


        /// <summary>
        /// Metoden uppdaterar en Person's för- och efternamn
        /// Validering av indata sker i Person objektets set properties
        /// </summary>
        /// <param name="person">Person objektet som skall uppdateras</param>
        /// <param name="strFName">Personens förnamn. Måste vara mellan 2 och 10 tecken</param>
        /// <param name="strLName">Personens efternamn. Måste vara mellan 3 och 15 tecken</param>
        /// <exception cref="ArgumentException">Kastas om förnamnet inte är mellan 2 och 10 tecken. Kastas om efternamnet inte är mellan 3 och 15 tecken</exception>
        /// <exception cref="ArgumentNullException">>Kastas om referensen till Person är null. Kastas om förnamnet är null eller en tom sträng. Kastas om efternamnet är null eller tom sträng</exception>
        public void SetName(Person person, string strFName, string strLName)
        {
            if (person == null)
                throw new ArgumentNullException("PersonHandler->SetName(). Person referensen är null");

            /*
            if (String.IsNullOrWhiteSpace(strFName))
                throw new ArgumentNullException("PersonHandler->SetName(). FName är obligatoriskt.");

            if (strFName.Length < 2 || strFName.Length > 10)
                throw new ArgumentException("PersonHandler->SetName(). FName måste vara mellan 2 och 10 tecken.");

            if (String.IsNullOrWhiteSpace(strLName))
                throw new ArgumentNullException("PersonHandler->SetName(). LName är obligatoriskt.");

            if (strLName.Length < 3 || strLName.Length > 15)
                throw new ArgumentException("PersonHandler->SetName(). LName måste vara mellan 3 och 15 tecken.");*/

            try
            {
                person.FName = strFName;
                person.LName = strLName;
            }
            catch(Exception)
            {
                throw;
            }
        }


        /// <summary>
        /// Metoden skapar ett nytt Person objekt
        /// Validering av indata sker i Person objektets set properties
        /// </summary>
        /// <param name="iAge">Personens ålder. Måste vara större än 0</param>
        /// <param name="strFName">Personens förnamn. Måste vara mellan 2 och 10 tecken</param>
        /// <param name="strLName">Personens efternamn. Måste vara mellan 3 och 15 tecken</param>
        /// <param name="dblHeight">Personens längd</param>
        /// <param name="dblWeight">Personens vikt</param>
        /// <returns>Nytt Person objekt med data</returns>
        /// <exception cref="ArgumentException">Kastas om ålder inte är större än 0. Kastas om förnamnet inte är mellan 2 och 10 tecken. Kastas om efternamnet inte är mellan 3 och 15 tecken</exception>
        /// <exception cref="ArgumentNullException">Kastas om förnamnet är null eller en tom sträng. Kastas om efternamnet är null eller tom sträng</exception>
        public Person CreatePerson(int iAge, string strFName, string strLName, double dblHeight, double dblWeight)
        {      
            /*
            // Validera att indata är korrekt
            if (iAge <= 0)
                throw new ArgumentException("PersonHandler->CreatePerson(). Ålder måste vara större än 0");

            if(String.IsNullOrWhiteSpace(strFName))
                throw new ArgumentNullException("PersonHandler->CreatePerson(). FName är obligatoriskt.");

            if (strFName.Length < 2 || strFName.Length > 10)
                throw new ArgumentException("PersonHandler->CreatePerson(). FName måste vara mellan 2 och 10 tecken.");

            if(String.IsNullOrWhiteSpace(strLName))
                throw new ArgumentNullException("PersonHandler->CreatePerson(). LName är obligatoriskt.");

            if (strLName.Length < 3 || strLName.Length > 15)
                throw new ArgumentException("PersonHandler->CreatePerson(). LName måste vara mellan 3 och 15 tecken.");*/

            Person newPerson = null;
            try
            {
                // Skapa ett nytt Person objekt
                newPerson = new Person(strFName, strLName);
                newPerson.Age = iAge;
                newPerson.Height = dblHeight;
                newPerson.Weight = dblWeight;
            }
            catch(Exception)
            {
                throw;
            }

            return newPerson;
        }
    }
}
