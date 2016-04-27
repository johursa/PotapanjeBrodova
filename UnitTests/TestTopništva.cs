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
    }
}
