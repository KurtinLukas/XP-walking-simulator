using System;
using System.Reflection.Emit;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using XP_walking_simulator;
using static XP_walking_simulator.Hrac;

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

        //kontrola správného přidání XP
        [TestMethod]
        public void pridejxpckaPOS1()
        {
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda,Hrac.Oblicej.VelkyNos,Hrac.Vlasy.Pleska,"special");
            int xp = 5;
            int puvodni = hrac.XP;
            hrac.PridejXP(xp);
            Assert.AreEqual(xp + puvodni, hrac.XP);
        }
        [TestMethod]
        public void pridejxpckaNEG1()
        {
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda,Hrac.Oblicej.VelkyNos,Hrac.Vlasy.Pleska,"special");
            int xp = 5;
            int puvodni = hrac.XP;
            hrac.PridejXP(xp);
            Assert.AreNotEqual(xp + puvodni, hrac.XP);
        }
        //kontrola zvýšení levelu
        [TestMethod]
        public void pridejxpckaPOS2()
        {
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda,Hrac.Oblicej.VelkyNos,Hrac.Vlasy.Pleska,"special");
            int xp = 105;
            int puvodni = hrac.XP;
            int level = hrac.Level;
            hrac.PridejXP(xp);
            Assert.IsTrue((5 == hrac.XP) && (level + 1 == hrac.Level));
        }
        [TestMethod]
        public void pridejxpckaNEG2()
        {
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            int xp = 105;
            int puvodni = hrac.XP;
            int level = hrac.Level;
            hrac.PridejXP(xp);
            Assert.IsTrue((5 == hrac.XP) && (level == hrac.Level));
        }
        [TestMethod]
        //testování funkčnosti hernipostava - ToString()
        public void toStringPOS1()
        {
            HerniPostava hrac = new HerniPostava();
            int xp = 5;
            hrac.Jmeno = "aaa";
            Assert.AreEqual(string.Format("Jmeno {0};Level {1};X {2};Y {3}", "aaa", 5, 0, 0),hrac.ToString());
        }
        [TestMethod]
        public void toStringNEG1()
        {
            HerniPostava hrac = new HerniPostava();
            int xp = 5;
            hrac.Jmeno = "aaa";
            Assert.AreNotEqual(string.Format("Jmeno {0};Level {1};X {2};Y {3}", "aaa", 5, 0, 0), hrac.ToString());
        }
        [TestMethod]
        //testování funkčnosti hrac - ToString()
        public void toStringPOS2()
        {
            HerniPostava n = new HerniPostava();
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda,Hrac.Oblicej.VelkyNos,Hrac.Vlasy.Pleska,"special");
            string test = string.Format(" Specializace - {0} BarvaVlasu - {1} Oblicej - {2} Vlasy - {3} XP - {4}", Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            Assert.AreEqual(n.ToString() + test, hrac.ToString());
        }
        [TestMethod]
        public void toStringNEG2()
        {
            HerniPostava n = new HerniPostava();
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            string test = string.Format(" Specializace - {0} BarvaVlasu - {1} Oblicej - {2} Vlasy - {3} XP - {4}", Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            Assert.AreNotEqual(n.ToString() + test, hrac.ToString());
        }
        [TestMethod]
        //testování funkčnosti npc - ToString()
        public void toStringPOS3()
        {
            HerniPostava n = new HerniPostava();
            NPC hrac = new NPC(NPC.PopisPrace.obchodnik,true);
            string test = string.Format("PopisNPC - {0} {1}", NPC.PopisPrace.obchodnik, true);
            Assert.AreEqual(n.ToString() + test, hrac.ToString());
        }
        [TestMethod]
        public void toStringNEG3()
        {
            HerniPostava n = new HerniPostava();
            Hrac hrac = new Hrac(Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            string test = string.Format(" Specializace - {0} BarvaVlasu - {1} Oblicej - {2} Vlasy - {3} XP - {4}", Hrac.BarvaVlasu.Hneda, Hrac.Oblicej.VelkyNos, Hrac.Vlasy.Pleska, "special");
            Assert.AreNotEqual(n.ToString() + test, hrac.ToString());
        }
        //správná změna pozice u npc
        [TestMethod]
        public void ZmenaLokacePOS2()
        {
            NPC postava = new NPC(NPC.PopisPrace.obchodnik);
            int x = 2, y = 1;
            postava.ZmenaPozice(x, y);
            Assert.IsFalse(postava.X == x && postava.Y == y);
        }
        [TestMethod]
        public void ZmenaLokaceNEG2()
        {
            NPC postava = new NPC(NPC.PopisPrace.obchodnik);
            int x = 2, y = 1;
            postava.ZmenaPozice(x, y);
            Assert.IsTrue(postava.X == x && postava.Y == y);
        }
        //testovani sily
        [TestMethod]
        public void SilaPOS()
        {
            NPC postava = new NPC(NPC.PopisPrace.obchodnik);
            Assert.IsFalse(postava.Sila);
        }
        [TestMethod]
        public void SilaNEG()
        {
            NPC postava = new NPC(NPC.PopisPrace.obchodnik);
            Assert.IsTrue(postava.Sila);
        }
    }
}
