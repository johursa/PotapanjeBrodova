﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
   public interface IPucaČ
    {
        Polje UputiPucanj();
        void EvidentirajRezultat(RezultatGađanja rezultat);
        IEnumerable<Polje> PogođenaPolja { get; }
    }
}
