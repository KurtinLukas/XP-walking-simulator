using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XP_walking_simulator;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //test, jestli je jmeno kratsi nez 11, <11 = true; >10 = false
        [TestMethod]
        public void JmenoPOS()
        {
            string jmeno = "1234567890";
            HerniPostava postava = new HerniPostava();
            postava.Jmeno = "1234567890";
            Assert.AreEqual(postava.Jmeno, jmeno);
        }
        [TestMethod]
        public void JmenoNEG()
        {
            string jmeno = "12345678901";
            HerniPostava postava = new HerniPostava();
            postava.Jmeno = "12345678901";
            Assert.AreEqual(postava.Jmeno, jmeno);
        }

        //správná funkce konstruktoru -> lvl = 1; X a Y == 0 
        [TestMethod]
        public void InicalizacePOS()
        {
            HerniPostava postava = new HerniPostava();
            Assert.IsTrue(postava.X == 0 && postava.Y == 0 && postava.Level == 1);
        }
        [TestMethod]
        public void InicalizaceNEG()
        {
            HerniPostava postava = new HerniPostava();
            Assert.IsFalse(postava.X == 0 && postava.Y == 0 && postava.Level == 1);
        }

        //správná změna pozice
        [TestMethod]
        public void ZmenaLokacePOS()
        {
            HerniPostava postava = new HerniPostava();
            int x = 2, y = 1;
            postava.ZmenaPozice(x, y);
            Assert.IsTrue(postava.X == x && postava.Y == y);
        }
        [TestMethod]
        public void ZmenaLokaceNEG()
        {
            HerniPostava postava = new HerniPostava();
            int x = 2, y = 1;
            postava.ZmenaPozice(x, y);
            Assert.IsFalse(postava.X == x && postava.Y == y);
        }

        //kontrola přidání XP
        [TestMethod]
        public void pridejxpckaPOS()
        {
            Hrac hrac = new Hrac();
            int xp = 5;
            int puvodni = hrac.XP;
            hrac.PridejXP(xp);
            Assert.AreEqual(xp + puvodni, hrac.XP);
        }
        [TestMethod]
        public void pridejxpckaNEG()
        {
            Hrac hrac = new Hrac();
            int xp = 5;
            int puvodni = hrac.XP;
            hrac.PridejXP(xp);
            Assert.AreNotEqual(xp + puvodni, hrac.XP);
        }
    }
}
