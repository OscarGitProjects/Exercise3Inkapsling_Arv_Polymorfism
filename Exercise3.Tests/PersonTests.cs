using Exercise3Inkapsling_Arv_Polymorfism;
using NUnit.Framework;
using System;
using System.Text;

namespace Exercise3.Tests
{
    public class PersonTests
    {
        Person person = null;

        [SetUp]
        public void Setup()
        {
            person = new Person("Kalle", "Andersson");
        }

        /// <summary>
        /// Metoden testar att konstruktorn fungerar korrekt
        /// Sätter FName och LName med konstruktorn. Testar get property på dessa plus testar get på Name property
        /// </summary>
        [Test]
        public void Person_Constructor_Get_FName_LName_Name_Test()
        {
            // Arrange
            // expected            

            // Act
            // actual
            string strFName = person.FName;
            string strLName = person.LName;
            string strName = person.Name;

            // Assert
            Assert.AreEqual("Kalle", strFName);
            Assert.AreEqual("Andersson", strLName);
            Assert.AreEqual("Kalle Andersson", strName);
        }


        /// <summary>
        /// Metoden testar att Person objektets ToString returnerar rätt resultat
        /// </summary>
        [Test]
        public void Person_ToString_Test()
        {
            // Arrange
            // expected
            person.Age = 33;
            person.Height = 178.50;
            person.Weight = 78.50;

            StringBuilder strBuilder = new StringBuilder(person.Name);
            strBuilder.Append(System.Environment.NewLine);
            strBuilder.Append($"Är 33 år.");
            strBuilder.Append($" Väger 78,5 kg.");
            strBuilder.Append($" Längden är 178,5 cm.");
            string strExpected = strBuilder.ToString();

            // Act
            // actual
            string strActual = person.ToString();

            // Assert
            Assert.AreEqual(strExpected, strActual);
        }

        #region Test av property FName

        /// <summary>
        /// Metoden testar Set and Get FName med nytt namn
        /// </summary>
        [Test]
        public void Person_Set_Get_FName_Test()
        {
            // Arrange
            // expected
            person.FName = "Stina";

            // Act
            // actual
            string strFName = person.FName;

            // Assert
            Assert.AreEqual("Stina", strFName);
        }

        /// <summary>
        /// Metoden testar att vi får ArgumentNullException när vi Set FName till null
        /// </summary>
        [Test]
        public void Person_Set_FName_With_null_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => person.FName = null);
        }


        /// <summary>
        /// Metoden testar att vi får ArgumentException om vi Set FNamn med färre tecken än 2. Vi testar med 1 tecken
        /// </summary>
        [Test]
        public void Person_Set_FName_With_To_Small_FName_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => person.FName = "1");
        }


        /// <summary>
        /// Metoden testar att vi får ArgumentException om vi Set FName med fler än 10 tecken
        /// </summary>
        [Test]
        public void Person_Set_FName_With_To_Big_FName_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => person.FName = "12345678901");
        }

        #endregion // End of region Test av property FName


        #region Test av property LName

        /// <summary>
        /// Metoden testar att Set and Get LName med nytt namn
        /// </summary>
        [Test]
        public void Person_Set_Get_LName_Test()
        {
            // Arrange
            // expected
            person.LName = "Nilsson";

            // Act
            // actual
            string strLName = person.LName;

            // Assert
            Assert.AreEqual("Nilsson", strLName);
        }

        /// <summary>
        /// Metoden testar att vi får ArgumentNullException när vi Set LName till null
        /// </summary>
        [Test]
        public void Person_Set_LName_With_null_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => person.LName = null);
        }


        /// <summary>
        /// Metoden testar att vi får ArgumentException om vi Set LName med mindre än 3 tecken. Vi testar 2 tecken
        /// </summary>
        [Test]
        public void Person_Set_LName_With_To_Small_LName_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => person.LName = "12");
        }


        /// <summary>
        /// Metoden testar att vi får ArgumentException om vi Set FLamn med fler tecken än 15
        /// </summary>
        [Test]
        public void Person_Set_LName_With_To_Big_LName_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => person.LName = "1234567890123456");
        }

        #endregion // End of region Test av property LName


        #region Test av property Age

        /// <summary>
        /// Metoden testar Set and Get av Age
        /// </summary>
        [Test]
        public void Person_Set_Get_Age_Test()
        {
            // Arrange
            // expected
            person.Age = 123;

            // Act
            // actual
            int iAge = person.Age;

            // Assert
            Assert.AreEqual(123, iAge);
        }

        /// <summary>
        /// Metoden testar att vi får ArgumentException om vi Set Age till 0
        /// </summary>
        [Test]
        public void Person_Set_Age_With_Wrong_Value_Test()
        {
            // Arrange
            // expected

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => person.Age = 0);
        }

        #endregion // End of region Test av property Age


        #region Test av property Height

        /// <summary>
        /// Metoden testar Set and Get av Height
        /// </summary>
        [Test]
        public void Person_Set_Get_Height_Test()
        {
            // Arrange
            // expected
            person.Height = 123.45;

            // Act
            // actual
            double dblHeight = person.Height;

            // Assert
            Assert.AreEqual(123.45, dblHeight);
        }

        #endregion // End of region Test av property Height


        #region Test av property Weight

        /// <summary>
        /// Metoden testar Set and Get av Weight
        /// </summary>
        [Test]
        public void Person_Set_Get_Weight_Test()
        {
            // Arrange
            // expected
            person.Weight = 123.45;

            // Act
            // actual
            double dblWeight = person.Weight;

            // Assert
            Assert.AreEqual(123.45, dblWeight);
        }

        #endregion // End of region Test av property Weight


        #region Test av property Name

        /// <summary>
        /// Metoden testar Get med property Name
        /// </summary>
        [Test]
        public void Person_Set_FName_LName_And_Get_Name_Test()
        {
            // Arrange
            // expected

            // Act
            // actual
            string strName = person.Name;

            // Assert
            Assert.AreEqual("Kalle Andersson", strName);
        }

        #endregion // End of region Test av property Name
    }
}