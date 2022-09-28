using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffe
{
    public class Kunde
    {
        // properties
        public string Name { get; set; }

        // konstruktør
        public Kunde(String navn)
        {
            Name = navn;
        }

        // ToString
        public override string ToString()
        {
            return $"Navn={Name}";
        }

    }
}
