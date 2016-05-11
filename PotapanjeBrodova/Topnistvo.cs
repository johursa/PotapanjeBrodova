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
        public Topnistvo(int redaka, int stupaca, int[] duljineBrodova)
        {
            mreža = new Mreža(redaka, stupaca);
            this.duljineBrodova = new List<int>(duljineBrodova);
            this.duljineBrodova.Sort((d1, d2) => d2 - d1);
            PromjeniTaktikuUNapipavanje();
        }
        
        public Polje UputiPucanj()
        {
            return pucač.UputiPucanj();


        }
        public void ObradiGađanje(RezultatGađanja rezultat)
        {

        }
        private void PromjeniTaktikuUNapipavanje()
        {
            TrenutnaTaktika = TaktikaGađanja.Napipavanje;
            // pucač = new Napipač(mreža, duljinaBroda);
            pucač = new Napipač(mreža, duljineBrodova[0]);

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
        IPucaČ pucač;
        Mreža mreža;
        List<int> duljineBrodova;
    }
}
