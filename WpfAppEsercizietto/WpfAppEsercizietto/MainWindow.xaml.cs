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

namespace WpfAppEsercizietto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public List<Cliente> clienti;
        public List<Appartamento> appartamenti;

        private void btn_Prenota_Click(object sender, RoutedEventArgs e)
        {
            int cod_Fis = int.Parse(txtBox_Nome.Text);
            string nome = txtBox_Nome.Text;
            string cognome = txtBox_Cognome.Text;

            Cliente c = new Cliente(nome, cognome, cod_Fis);
            clienti.Add(c);

            MessageBox.Show($"Cliente Aggiunto con successo! \n{c}");
        }






        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
    }
}