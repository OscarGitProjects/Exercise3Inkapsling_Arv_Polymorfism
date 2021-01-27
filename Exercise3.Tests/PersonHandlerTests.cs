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
        [Description("Metoden testar att SetAge kastar ArgumentException om värdet är 0 eller")]
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
    }
}
