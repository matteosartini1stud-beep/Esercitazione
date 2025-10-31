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
        private int numeroTracce;
        private double durataTotale; // in minuti
        // Costruttore
        public Cd(string titolo, string autore, int numeroTracce, double durataTotale)
        {
            this.titolo = titolo;
            this.autore = autore ;
            this.numeroTracce = numeroTracce;
            this.durataTotale = durataTotale;
        }
        // Metodi Getter
        public string GetTitolo()
        {
            return titolo;
        }
        public string GetAutore()
        {
            return autore;
        }
        public int GetNumeroTracce()
        {
            return numeroTracce;
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
            Console.WriteLine("Numero di Tracce: " + numeroTracce);
            Console.WriteLine("Durata Totale: " + durataTotale + " minuti");
        }
    }
}
