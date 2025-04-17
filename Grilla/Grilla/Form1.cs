using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grilla
{
    public partial class frmGrilla : Form
    {
        // Variable que se usa para cualquier procedimiento de este formulario
        int nro; 

        public frmGrilla()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            // Agregar un renglon para la escritura
            int renglon = dtgvDatos.Rows.Add();

            // Colocamos los datos en las columnas de esa fila
            dtgvDatos.Rows[renglon].Cells[0].Value = txtCodigoProducto.Text;
            dtgvDatos.Rows[renglon].Cells[1].Value = txtNombreProducto.Text;
            dtgvDatos.Rows[renglon].Cells[2].Value = txtCantidad.Text;

            // Blanqueo de los textBox
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            txtCantidad.Text = "";

            // El foco se instala en el objeto
            txtCodigoProducto.Focus();
        }

        private void dtgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Muestra la posicion de la fila seleccionada
            nro = e.RowIndex;

            if(nro != -1)
            {
                MessageBox.Show((string)dtgvDatos.Rows[nro].Cells[1].Value);
            }
            else
            {
                MessageBox.Show("¡Seleccionó el Encabezado!");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dtgvDatos.Rows.RemoveAt(nro);
        }
    }
}
