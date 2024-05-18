using System.IO;
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

namespace Carga_datos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Juegos> juegos = new List<Juegos>();

        public MainWindow()
        {
            InitializeComponent();
            juegos.Add(new Juegos() { Eq1 = "Barcelona", Eq2 = "Real Madrid", puntaje1 = 3, puntaje2 = 2, Progreso = 85 });
            juegos.Add(new Juegos() { Eq1 = "PSG", Eq2 = "Bayer Munich", puntaje1 = 3, puntaje2 = 5, Progreso = 55 });
            juegos.Add(new Juegos() { Eq1 = "BVB Dormudt", Eq2 = "As Roma", puntaje1 = 0, puntaje2 = 1, Progreso = 25 });
            juegos.Add(new Juegos() { Eq1 = "Man unite", Eq2 = "Ajax", puntaje1 = 1, puntaje2 = 1, Progreso = 15 });

            lbJuego.ItemsSource = juegos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lbJuego.SelectedItem != null)
            {
                MessageBox.Show("Juegos Seleccionados: " + (lbJuego.SelectedItem as Juegos).Eq1 + " " +
                    (lbJuego.SelectedItem as Juegos).puntaje1 + " " + (lbJuego.SelectedItem as Juegos).Eq2 + " " +
                    (lbJuego.SelectedItem as Juegos).puntaje2);
            }
        }

        private void btnCargarDatos_Click(object sender, RoutedEventArgs e)
        {
            juegos.Clear();
            string rutaArchivo = "C:\\Users\\tgpp1\\OneDrive\\Escritorio\\Carga_datos\\datos.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(',');

                Juegos nuevoJuego = new Juegos()
                {
                    Eq1 = valores[0],
                    puntaje1 = int.Parse(valores[1]),
                    Eq2 = valores[2],
                    puntaje2 = int.Parse(valores[3]),
                    Progreso = int.Parse(valores[4])
                };

                juegos.Add(nuevoJuego);

            }

            lbJuego.ItemsSource = null;
            lbJuego.ItemsSource = juegos;
        }
    }
}