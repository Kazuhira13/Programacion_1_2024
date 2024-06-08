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

namespace FinalSerie2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            recudato();
        }

        private void recudato()
        {
            DataAccess dataAccess = new DataAccess();
            List<Ventas> ventas = dataAccess.GetAllDapper();
            dataGrid.ItemsSource = ventas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow updateWindow = new UpdateWindow();
            updateWindow.Closed += Windows_Closed;
            updateWindow.ShowDialog();
        }

        private void Windows_Closed(object? sender, EventArgs e)
        {
            recudato();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Ventas)dataGrid.SelectedItem).Id;
            cambiardatos cambiardatos = new cambiardatos(id);
            cambiardatos.Show();
            cambiardatos.Closed += Windows_Closed;
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Ventas)dataGrid.SelectedItem).Id;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Estas seguro que deseas eliminar el registro?", "Confirmacion de borrado", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                DataAccess dataAccess = new DataAccess();
                dataAccess.Delete(id);
                MessageBox.Show("El registro ha sido eliminado");
                recudato();
            }
        }

        private void updateBtn_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}