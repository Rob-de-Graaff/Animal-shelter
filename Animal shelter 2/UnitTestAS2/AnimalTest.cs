using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Animal_shelter_2;

namespace UnitTestAS2
{
    [TestClass]
    public class AnimalTest
    {
        #region fields
        private Dog d;
        private Cat c;
        private string noise;
        private DateTime lastWalkDate;
        private string name = "animal";
        private string badHabits = "is vals";
        private Gender gender;
        #endregion

        #region initialize
        [TestInitialize]
        public void Initialize()
        {
            lastWalkDate = new DateTime(01, 01, 1000);
            d = new Dog(name, gender, lastWalkDate, noise);
            c = new Cat(name, gender, badHabits, noise);
        }
        #endregion

        #region Tests
        [TestMethod]
        public void DNoise()
        {
            string Noise = d.MakeNoise();
            Assert.AreEqual("woef", Noise);
        }

        [TestMethod]
        public void CNoise()
        {
            string Noise = c.MakeNoise();
            Assert.AreEqual("miauw", Noise);
        }

        [TestMethod]
        public void DPrijs()
        {
            int prijs = d.price();
            Assert.AreEqual(500, prijs);
        }

        [TestMethod]
        public void CPrijs()
        {
            int prijs = c.price();
            Assert.AreEqual(350, prijs);
        }
        #endregion
    }
}