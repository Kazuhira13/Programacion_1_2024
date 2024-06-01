using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño
{
    public partial class ProveDatos : Form
    {
        public ProveDatos()
        {
            InitializeComponent();
        }

        private void ProveDatos_Load(object sender, EventArgs e)
        {
            refressPantalla();
           textid.Enabled = false;
        }

        public void refressPantalla()
        {
            dataGridView1.DataSource = PersonaDAL.PresentarRegistro();
        }
      
        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textnombre.Text) || string.IsNullOrWhiteSpace(textnum.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos antes de continuar.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Persona persona = new Persona();
            persona.nombre= textnombre.Text;
            persona.telefono=textnum.Text;

            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                if (id != null)
                {
                    persona.id = id;
                    int result = PersonaDAL.ModificarPersona(persona);

                    if (result > 0)
                    {
                        MessageBox.Show("Exito al Modificar");
                    }
                    else
                    {
                        MessageBox.Show("Error al Modificar");
                    }
                }
            }
            else
            {


                int result = PersonaDAL.AgregarPersona(persona);

                if (result > 0)
                {
                    MessageBox.Show("Exito al Guardar");
                }
                else
                {
                    MessageBox.Show("Error al Guardar");
                }
            }

            refressPantalla();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            textid.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            textnombre.Text= Convert.ToString(dataGridView1.CurrentRow.Cells["nombre"].Value);
            textnum.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["telefono"].Value);
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                int resultado = PersonaDAL.EliminarPersona(id);
                if (resultado > 0)
                {
                    MessageBox.Show("Eliminado con existo");
                }
                else
                {
                    MessageBox.Show("Error al eliminar");
                }
            }
            refressPantalla();
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textid.Clear();
            textnombre.Clear();
            textnum.Clear();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
