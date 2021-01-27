using Exercise3Inkapsling_Arv_Polymorfism;
using NUnit.Framework;
using System;

namespace Exercise3.Tests
{
    /// <summary>
    /// Test klass som testar PersonHandler klassen
    /// </summary>
    public class PersonHandlerTests
    {
        Person person = null;

        [SetUp]
        public void Setup()
        {            
            person = new Person("Kalle", "Andersson");
            person.Age = 33;
            person.Height = 178.5;
            person.Weight = 78.5;
        }


        #region Test av metoden SetAge 

        /// <summary>
        /// Metoden testar att SetAge metoden gör en korrekt uppdatering av Age i Person objektet
        /// </summary>
        [Test]
        [Description("Metoden testar att SetAge metoden fungerar korrekt")]
        public void PersonHandler_SetAge_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();
            personHandler.SetAge(person, 44);

            // Act
            // actual
            int iActualAge = person.Age;

            // Assert
            Assert.AreEqual(44, iActualAge);            
        }


        /// <summary>
        /// Metoden testar att metoden SetAge kastar ArgumentNullException om referensen till Person objektet är null
        /// </summary>
        [Test]
        [Description("Metoden testar att SetAge kastar ArgumentNullException om referense till Person objektet är null")]
        public void PersonHandler_SetAge_Person_Argument_null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetAge(null, 44));
        }


        /// <summary>
        /// Metoden testar att metoden SetAge kastar ArgumentException om värdet för age är 0 eller mindre
        /// </summary>
        [Test]
        [Description("Metoden testar att SetAge kastar ArgumentException om värdet är 0")]
        public void PersonHandler_SetAge_Age_Is_0_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => personHandler.SetAge(person, 0));
        }

        #endregion  // End of region Test av metoden SetAge 


        #region Test av metoden CreatePerson 

        /// <summary>
        /// Metoden testar att CreatePerson metoden fungerar korrekt
        /// Metoden testar att CreatePerson metoden fungerar korrekt
        /// </summary>
        [Test]
        [Description("Metoden testar att CreatePerson metoden fungerar korrekt")]
        public void PersonHandler_CreatePerson_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();
            Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual

            // Assert
            Assert.AreEqual(33, newPerson.Age);
            Assert.AreEqual("Stina", newPerson.FName);
            Assert.AreEqual("Andersson", newPerson.LName);
            Assert.AreEqual(165.5, newPerson.Height);
            Assert.AreEqual(62.5, newPerson.Weight);
        }


        /// <summary>
        /// Metoden testar att anropa metoden CreatePerson med age 0. Skall då kasta undantaget ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med age 0 kastar undantaget ArgumentException")]
        public void PersonHandler_CreatePerson_Wrong_Age_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(0, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentException>(() => personHandler.CreatePerson(0, "Stina", "Andersson", 165.5, 62.5));
        }


        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med FName null kastar undantaget ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med FName null kastar undantaget ArgumentNullException")]
        public void PersonHandler_CreatePerson_FName_Null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentNullException>(() => personHandler.CreatePerson(33, null, "Andersson", 165.5, 62.5));
        }


        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med FName som är mindre än 2 tecken. Skall kasta undantaget ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med FName som är mindre än 2 tecken. Skall kasta undantaget ArgumentException")]
        public void PersonHandler_CreatePerson_FName_To_Small_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentException>(() => personHandler.CreatePerson(33, "1", "Andersson", 165.5, 62.5));
        }


        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med FName som är längre än 10 tecken. Skall kasta undantaget ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med FName som är längre än 10 tecken. Skall kasta undantaget ArgumentException")]
        public void PersonHandler_CreatePerson_FName_To_Big_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentException>(() => personHandler.CreatePerson(33, "12345678901", "Andersson", 165.5, 62.5));
        }



        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med FName null kastar undantaget ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med LName null kastar undantaget ArgumentNullException")]
        public void PersonHandler_CreatePerson_LName_Null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentNullException>(() => personHandler.CreatePerson(33, "Stina", null, 165.5, 62.5));
        }


        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med FName som är mindre än 3 tecken. Skall kasta undantaget ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med LName som är mindre än 3 tecken. Skall kasta undantaget ArgumentException")]
        public void PersonHandler_CreatePerson_LName_To_Small_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentException>(() => personHandler.CreatePerson(33, "Stina", "12", 165.5, 62.5));
        }


        /// <summary>
        /// Metoden testar att ett anrop till CreatePerson med LName som är längre än 15 tecken. Skall kasta undantaget ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till CreatePerson med LName som är längre än 15 tecken. Skall kasta undantaget ArgumentException")]
        public void PersonHandler_CreatePerson_LName_To_Big_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            //Person newPerson = personHandler.CreatePerson(33, "Stina", "Andersson", 165.5, 62.5);

            // Act
            // actual
            Assert.Throws<ArgumentException>(() => personHandler.CreatePerson(33, "Stina", "1234567890123456", 165.5, 62.5));
        }

        #endregion  // End of region Test av metoden CreatePerson 


        #region Test av metoden SetHeight

        /// <summary>
        /// Metoden testar att SetHeight fungerar korrekt
        /// </summary>
        [Test]
        [Description("Metoden testar att SetHeight fungerar korrekt")]
        public void PersonHandler_SetHeight_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();
            personHandler.SetHeight(person, 12.3);

            // Act
            // actual
            double dblActualHeight = person.Height;

            // Assert
            Assert.AreEqual(12.3, dblActualHeight);
        }


        /// <summary>
        /// Metoden testar att SetHeight vid anrop med Person objektet är null kastar ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att SetHeight vid anrop med Person objektet är null kastar ArgumentNullException")]
        public void PersonHandler_SetHeight_Person_Null()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetHeight(null, 12.3));
        }

        #endregion  // End of region Test av metoden SetHeight


        #region Test av metoden SetWeight

        /// <summary>
        /// Metoden testar att SetWeight fungerar korrekt
        /// </summary>
        [Test]
        [Description("Metoden testar att SetWeight fungerar korrekt")]
        public void PersonHandler_SetWeight_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();
            personHandler.SetWeight(person, 12.3);

            // Act
            // actual
            double dblActualWeight = person.Weight;

            // Assert
            Assert.AreEqual(12.3, dblActualWeight);
        }


        /// <summary>
        /// Metoden testar att SetWeigh vid anrop med Person objektet är null kastar ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att SetWeigh vid anrop med Person objektet är null kastar ArgumentNullException")]
        public void PersonHandler_SetWeight_Person_Null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual
            double dblActualWeight = person.Weight;

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetWeight(null, 78.3));
        }

        #endregion  // End of region Test av metoden SetWeight


        #region Test av metoden SetName

        /// <summary>
        /// Metoden testar att SetName fungerar korrekt
        /// </summary>
        [Test]
        [Description("Metoden testar att SetName fungerar korrekt")]
        public void PersonHandler_SetName_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();
            string strExpectedFName = "Berit";
            string strExpectedLName = "Nilsson";

            personHandler.SetName(person, strExpectedFName, strExpectedLName);

            // Act
            // actual
            string strActualFName = person.FName;
            string strActualLName = person.LName;

            // Assert
            Assert.AreEqual(strExpectedFName, strActualFName);
            Assert.AreEqual(strExpectedLName, strActualLName);
        }


        /// <summary>
        /// Metoden testar att ett anrop till SetName med Person null. Kastar undantaget ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att ett anrop till SetName med Person null kastar undantaget ArgumentNullException")]
        public void PersonHandler_SetName_Person_Null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetName(null, "Berit", "Nilsson"));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med FName null. Kastar undantaget ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med FName null. Kastar undantaget ArgumentNullException")]
        public void PersonHandler_SetName_FName_With_null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetName(person, null, "Nilsson"));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med FName som har färrev tecken än 2. Skall kasta ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med FName som har färre tecken än 2. Skall kasta ArgumentException")]
        public void PersonHandler_SetName_FName_With_To_Small_FName_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => personHandler.SetName(person, "1", "Nilsson"));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med FName som har fler tecken än 10. Skall kasta ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med FName som har flerc tecken än 10. Skall kasta ArgumentException")]
        public void PersonHandler_SetName_FName_With_To_Big_FName_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => personHandler.SetName(person, "12345678901", "Nilsson"));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med LName null. Kastar undantaget ArgumentNullException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med LName null. Kastar undantaget ArgumentNullException")]
        public void PersonHandler_SetName_LName_With_null_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentNullException>(() => personHandler.SetName(person, "Berit", null));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med LName som har färrev tecken än 3. Skall kasta ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med LName som har färre tecken än 3. Skall kasta ArgumentException")]
        public void PersonHandler_SetName_LName_With_To_Small_FName_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => personHandler.SetName(person, "Berit", "12"));
        }


        /// <summary>
        /// Metoden testar att anropa SetName med LName som har fler tecken än 15. Skall kasta ArgumentException
        /// </summary>
        [Test]
        [Description("Metoden testar att anropa SetName med LName som har fler tecken än 15. Skall kasta ArgumentException")]
        public void PersonHandler_SetName_LName_With_To_Big_FName_Test()
        {
            // Arrange
            // expected
            PersonHandler personHandler = new PersonHandler();

            // Act
            // actual

            // Assert
            Assert.Throws<ArgumentException>(() => personHandler.SetName(person, "Berit", "1234567890123456"));
        }


        #endregion  // End of region Test av metoden SetName
    }
}
