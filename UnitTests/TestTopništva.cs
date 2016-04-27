using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
namespace UnitTests
{
    [TestClass]
    public class TestTopništva
    {
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaJeNapipavanje()
        {
            Topnistvo t = new Topnistvo();
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonPrvogPogotkaJeOkruživanje()
        {
            Topnistvo t = new Topnistvo();
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.Okruživanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonDrugogPogotkaJeSustavnoUništavanje()
        {
            Topnistvo t = new Topnistvo();
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            t.ObradiGađanje(RezultatGađanja.Pogodak);
            Assert.AreEqual(TaktikaGađanja.SustavnoUništavanje, t.TrenutnaTaktika);
        }
        [TestMethod]
        public void Topništvo_PočetnaTaktikaGađanjaNakonPotonućaJeNapipavanje()
        {
            Topnistvo t = new Topnistvo();
            t.ObradiGađanje(RezultatGađanja.Potonuće);
            Assert.AreEqual(TaktikaGađanja.Napipavanje, t.TrenutnaTaktika);
        }
    }
}
