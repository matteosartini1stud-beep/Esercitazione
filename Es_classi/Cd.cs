using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_classi
{
    class Cd
    {
        // Attributi
        private string titolo;
        private string autore;
        private List<string> listaBrani;
        private double durataTotale; // in minuti
        // Costruttore
        public Cd(string titolo, string autore, List<string> listaBrani, double durataTotale)
        {
            this.titolo = titolo;
            this.autore = autore ;
            this.listaBrani = listaBrani;
            this.durataTotale = durataTotale;
        }
        // Metodi Getter
        public string Titolo
        {
            set{ titolo = value; }
            get{ return titolo; }
        }
        public string Autore
        {
            set{ autore = value; }
            get{ return autore; }
        }
        public List<string> GetListaBrani()
        {
            return listaBrani;
        }
        public double GetDurataTotale()
        {
            return durataTotale;
        }
        // Metodo per visualizzare le informazioni del CD
        public void VisualizzaInfo()
        {
            Console.WriteLine("Titolo: " + titolo);
            Console.WriteLine("Artista: " + autore);
            Console.WriteLine("Lista Brani: " + listaBrani);
            Console.WriteLine("Durata Totale: " + durataTotale + " minuti");
        }
    }
}
