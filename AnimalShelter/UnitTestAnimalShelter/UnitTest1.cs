using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalShelter;

namespace UnitTestAnimalShelter
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDogCtor()
        {
            Dog d = new Dog("naamHond", true, 10); // gebruikt de constructor van Dog
            Assert.AreEqual(d.AnimalName, "naamHond");  // checkt of de naam goed is gegaan
            Assert.AreEqual(d.Gereserveerd, false); // checkt of hij standaard op niet gereserveerd staat
            Assert.AreEqual(d.Age, 10); // kijkt of de age goed is gegaan
            Assert.AreEqual(d.IsMan, true); // kijkt of de Isman goed is gegaan
        }
        [TestMethod]
        public void TestDogWalk()
        {
            Dog d = new Dog("naamHond", true, 10); //maakt een hond aan

            d.walkDog(DateTime.Now); //roept de methode aan om een hond uit te laten

            Assert.AreEqual(DateTime.Now.Day, d.lastwalk.Day); //kijkt of hij het op dezelfde dag zet als vandaag
        }
        [TestMethod]
        public void TestCatCtor()
        {
            Cat c = new Cat("naamCat", true, 10,"een lijst aan slechte gewoonten");

            Assert.AreEqual("naamCat", c.AnimalName);
            Assert.AreEqual(true, c.IsMan);
            Assert.AreEqual(10, c.Age);
            Assert.AreEqual("een lijst aan slechte gewoonten", c.Badhadbits);
        }
        [TestMethod]
        public void TestAnimalShelterCtor()
        {
            AnimalShelter.AnimalShelter a = new AnimalShelter.AnimalShelter();
            Assert.AreEqual("shelterSkelter", a.Name);
        }
    }
}
