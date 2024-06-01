using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capa_entidades;
using capa_negocio;

namespace Diseño
{
    public partial class Form1 : Form
    {
        Classentidades objent = new Classentidades();
        Classnegocio objneg = new Classnegocio();
        public Form1()
        {
            InitializeComponent();
        }

        void mantenimiento(String accion)
        {
            objent.codigo = textcodigo.Text;
            objent.nombre = textproducto.Text;
            objent.cantidad = Convert.ToInt32(textcantidad.Text);
            objent.accion = accion;
            String men = objneg.N_mantenimiento_clientes(objent);
            MessageBox.Show(men,"Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        void limpiar()
        {
            textcodigo.Text = "";
            textproducto.Text = "";
            textcantidad.Text = "";
            textbusqueda.Text = "";
            dataGridView1.DataSource=objneg.N_listar_clientes();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objneg.N_listar_clientes();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(textproducto.Text))
            {
                MessageBox.Show("Por favor, ingrese el nombre del producto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(textcantidad.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo Cantidad.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void registrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                if(MessageBox.Show("¿Deseas registrar a:" +textproducto.Text+"?","Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("1");
                    limpiar();
                }
            }

        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas modificar a:" + textproducto.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("2");
                    limpiar();
                }
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textcodigo.Text != "")
            {
                if (MessageBox.Show("¿Deseas eliminar a:" + textproducto.Text + "?", "Mensaje",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    mantenimiento("3");
                    limpiar();
                }
            }
        }

        private void textbusqueda_TextChanged(object sender, EventArgs e)
        {
            if(textbusqueda.Text != "")
            {
                objent.nombre = textbusqueda.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_buscar_clientes(objent);
                dataGridView1.DataSource = dt;
            }
            else 
            {
                dataGridView1.DataSource = objneg.N_listar_clientes();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dataGridView1.CurrentCell.RowIndex;

            textcodigo.Text = dataGridView1[0,fila].Value.ToString();
            textproducto.Text = dataGridView1[1, fila].Value.ToString();
            textcantidad.Text = dataGridView1[2, fila].Value.ToString();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
