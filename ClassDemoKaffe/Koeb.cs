using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffe
{
    public  class Koeb
    {
        // ingen attributter

        // instans felter

        // associering til Kunde
        private Kunde _kunde;

        // associering til Kaffe
        private Kaffe _kaffe;


        // konstruktør
        public Koeb(Kunde kunde, Kaffe kaffe)
        {
            _kunde = kunde;
            _kaffe = kaffe;
        }


        // ToString
        public override string ToString()
        {
            return $"Kunden er {_kunde} og har købt Kaffen {_kaffe}";
        }


    }
}
