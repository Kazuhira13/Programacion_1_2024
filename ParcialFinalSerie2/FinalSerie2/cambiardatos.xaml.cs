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

namespace FinalSerie2
{
    /// <summary>
    /// Lógica de interacción para cambiardatos.xaml
    /// </summary>
    public partial class cambiardatos : Window
    {
        public cambiardatos(int id)
        {
            InitializeComponent();
            DataAccess dataAccess = new DataAccess();
            Ventas ventas = dataAccess.GetById(id);
            txtid.Text = ventas.Id.ToString();
            txtname.Text = ventas.Nombre;
            txtprecio.Text = ventas.Precio;
            txtexistencia.Text = ventas.Existencias;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataAccess dataAccess = new DataAccess();
            Ventas ventas = new Ventas
            {
                Id = int.Parse(txtid.Text),
                Nombre = txtname.Text,
                Precio = txtprecio.Text,
                Existencias = txtexistencia.Text,
            };
            int result = dataAccess.update(ventas);
            if(result > 0)
            {
                MessageBox.Show("Se actualizo");
            }
            this.Close();
        }
    }
}
