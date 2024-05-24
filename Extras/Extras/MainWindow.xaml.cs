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

namespace Extras
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            recovDato();
        }

        private void recovDato()
        {
            DataAccess dataAccess = new DataAccess();
            List<Ventas> ventas = dataAccess.GetAllDapper();
            dataGrid.ItemsSource = ventas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Datos insertWindows = new Datos();
            insertWindows.Closed += Windows_Closed;
            insertWindows.ShowDialog();
            
        }

        private void Windows_Closed(object? sender, EventArgs e)
        {
            recovDato();
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Ventas)dataGrid.SelectedItem).Id;
            Update updatetWindows = new Update(id);
            updatetWindows.Closed += Windows_Closed;
            updatetWindows.ShowDialog();
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = ((Ventas)dataGrid.SelectedItem).Id;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Esta seguro que quiere borrar el registro?", "Confirmacion de borrado"
                ,System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes) 
            { 
                DataAccess dataAccess = new DataAccess();
                dataAccess.Delete(id);
                MessageBox.Show("El registro ha sido eliminado.");
                recovDato();
            }
        }
    }
}