using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Es_classi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Cd mioCd;

        public MainWindow()
        {
            InitializeComponent();
            mioCd = new Cd("Best Hits", "Artista Vari");
        }

        private void BtnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string titolo = TxtTitolo.Text;
                string autore = TxtAutore.Text;
                double durata = double.Parse(TxtDurata.Text);

                Brano nuovoBrano = new BranoEros(titolo, autore, durata);
                mioCd.AggiungiBrano(nuovoBrano);

                LstBrani.Items.Add(nuovoBrano); // Mostra nella ListBox
                TxtOutput.Text = $"Aggiunto: {nuovoBrano}";

                TxtTitolo.Text = TxtAutore.Text = TxtDurata.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }

        private void BtnMostraCd_Click(object sender, RoutedEventArgs e)
        {
            TxtOutput.Text = $"{mioCd}\nDurata totale: {mioCd.Durata()} minuti";
        }
    }
}
