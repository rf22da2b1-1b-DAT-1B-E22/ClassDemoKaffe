using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoKaffe
{
    public class Kaffe
    {
        /*
         * Attributter - eller instans felter
         */

        // navn givning _xxxxxxxXxxxxXxxx
        // access er private ('-' i UML)

        private String _land;
        private String _sort;
        private double _price;


        /*
         * Properties 
         */

        // navn givning XxxxXxxxXxx
        // access er public ('+' i UML)

        public String Land {
            get { return _land;  } 
            set { _land = value;  }  
        }

        public String Sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }


        /*
         * Metoder
         */

        // navn givning XxxxXxxxXxx
        // access er public ('+' i UML)

        public double PrisMedMoms()
        {
            return _price * 1.25;
        }


        /*
         * Konstruktør
         */

        // navn givning følger klasse navnet
        // access er public ('+' i UML)

        public Kaffe()
        {
            //_land = "";
            _sort = "";
            _price = -1;
        }

        public Kaffe(string land, string sort, double price)
        {
            _land = land;
            _sort = sort;
            _price = price;
        }



        /*
         * ToString
         */

        // navn givning  følger en bestemt skabelon (se nedenfor)
        // access er public (normalt ikke med i UML)

        public override string ToString()
        {
            return $"Land={_land} Sort={_sort} Pris={_price}";
        }

    }
}
