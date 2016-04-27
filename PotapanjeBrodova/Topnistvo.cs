using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
       Napipavanje,
       Okruživanje,
       SustavnoUništavanje

    }
  public  class Topnistvo
    {
        public Topnistvo()
        {
            PromjeniTaktikuUNapipavanje();
        }
        
        public Polje UputiPucanj()
        {
            throw new NotImplementedException();


        }
        public void ObradiGađanje(RezultatGađanja rezultat)
        {

        }
        private void PromjeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;

        }
        private void PromjeniTaktikuUOkruživanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Okruživanje;
        }
        private void PromjeniTaktikuUSustavnoUništavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.SustavnoUništavanje;

        }

        public TaktikaGađanja TrenutnaTaktika
        {
            get; private set;

        }
    }
}
