using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_classi
{
    class Brano
    {
        private string titolo;
        private string autore;
        private double durata;

        public Brano(string _titolo, string _autore, double _durata)
        {
            _titolo = titolo;
            _autore = autore;
            _durata = durata;
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public double Durata
        {
            get { return durata; }
            set { durata = value; }
        }

        public string toString()
        {
            return "Titolo: " + titolo + ", Autore: " + autore + ", Durata: " + durata + " minuti.";
        }

        public bool shortSong(double durata2)
        {
            if (durata < durata2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
