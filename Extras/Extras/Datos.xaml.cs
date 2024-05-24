using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Extras
{
    /// <summary>
    /// Lógica de interacción para Datos.xaml
    /// </summary>
    public partial class Datos : Window
    {
        public Datos()
        {
            InitializeComponent();
        }

        private void txtNombres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Ventas ventas = new Ventas
            {
                
                Nombres = txtNombres.Text,
                Productos = txtProducto.Text,
                Id = int.Parse(txtID.Text)
                

            };
            int result = dataAccess.Create(ventas);
            if (result >0 )
            {
                MessageBox.Show("alumno Guardado Correctamente");
            }
            this.Close();
        }
    }
}
