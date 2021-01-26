using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise3Inkapsling_Arv_Polymorfism
{
    /// <summary>
    /// Klass med information om en person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Personens ålder
        /// </summary>
        private int iAge;

        /// <summary>
        /// Get/set personens ålder
        /// </summary>
        public int Age
        {
            get { return iAge; }
            set 
            {
                if (value <= 0)
                    throw new ArgumentException("Person -> Age. Ålder måste vara större än 0");

                iAge = value; 
            }
        }

        /// <summary>
        /// Personens förnamn
        /// </summary>
        private string strFname;

        /// <summary>
        /// Get/set personens förnamn
        /// </summary>
        public string FName
        {
            get { return strFname; }
            set 
            {
                int? iLength = value?.Length;

                if (!iLength.HasValue)
                    throw new ArgumentException("Person -> FName. FName är obligatoriskt.");

                if (iLength.Value < 2)
                    throw new ArgumentException("Person -> FName. FName måste vara mellan 2 och 10 tecken.");

                if (iLength.Value > 10)
                    throw new ArgumentException("Person -> FName. FName måste vara mellan 2 och 10 tecken.");

                strFname = value; 
            }
        }


        /// <summary>
        /// Personens efternamn
        /// </summary>
        private string strLName;

        /// <summary>
        /// Get/Set personens efternammn
        /// </summary>
        public string LName
        {
            get { return strLName; }
            set
            {
                int? iLength = value?.Length;

                if (!iLength.HasValue)
                    throw new ArgumentException("Person -> LName. LName är obligatoriskt.");

                if (iLength.Value < 3)
                    throw new ArgumentException("Person -> LName. LName måste vara mellan 3 och 15 tecken.");

                if (iLength.Value > 15)
                    throw new ArgumentException("Person -> LName. LName måste vara mellan 3 och 15 tecken.");

                strLName = value;
            }
        }

        /// <summary>
        /// Personens längd
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Personens vikt
        /// </summary>
        public double Weight { get; set; }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="strFirstName">Förnamn</param>
        /// <param name="strLastName">Efternammn</param>
        public Person(string strFirstName, string strLastName)
        {

        }

    }
}
