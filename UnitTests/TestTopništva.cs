using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace UnitTests
{
    [TestClass]
    public class TestTopništva
    {
        int[] duljineBrodova = { 1, 2, 3 };

        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaJeNapipavanje()
        {
            Topnistvo t = new Topnistvo(10,10,duljineBrodova);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonPrvogPogotkaJeOkruživanje()
        {
            Topnistvo t = new Topnistvo(10,10,duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonDrugogPogotkaJeSustavnoUništavanje()
        {
            Topnistvo t = new Topnistvo(10,10,duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonPotonućaJeNapipavanje()
        {
            Topnistvo t = new Topnistvo(10,10,duljineBrodova);
            t.ObradiGađanje(RezultatGađanja.Potonuće);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
         public void Topništvo_NapipavanjeDajeBiloKojePoljeNaPraznojMreži()
         {
             Topnistvo t = new Topnistvo(10, 10, duljineBrodova);
             Assert.IsTrue(new Mreža(10,10).DajSlobodnaPolja().Contains(t.UputiPucanj()));
         }
   }
}
