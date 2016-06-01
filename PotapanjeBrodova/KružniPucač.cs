using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucaČ
    {
        public KružniPucač(Polje prvoPogođeno, Mreža mreža)
        {
            this.prvoPogođeno = prvoPogođeno;
            this.mreža = mreža;
        }

        public Polje UputiPucanj()
        {
            int redak = prvoPogođeno.Redak;
            int stupac = prvoPogođeno.Stupac;
           
            List<IEnumerable<Polje>> kandidati = new List<IEnumerable<Polje>>();
           foreach(Smjer smjer in Enum.GetValues(typeof(Smjer))) {
                mreža.DajPoljaUZadanomSmjeru(redak, stupac, smjer);

            }
            kandidati.Sort((lista1, lista2) => lista2.Count() - lista1.Count());
            var grupe=   kandidati.GroupBy(lista => lista.Count());
            var najdulji = grupe.First();
            if (najdulji.Count() == 1)
                return najdulji.First().First();
            int indeks = slučajni.Next(najdulji.Count());
            return najdulji.ElementAt(indeks).First();
        }

        public void EvidentirajRezultat(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
           PogođenaPolja.Add(zadnjeGađano);
           PogođenaPolja.Sort((a, b) => a.Redak - b.Redak + a.Stupac - b.Stupac);
        }

      

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                return PogođenaPolja;
            }
        }

        List<Polje> pogođenaPolja = new List<Polje>();
        Polje zadnjeGađano;
        Mreža mreža;
        Random slučajni = new Random();

    }
}