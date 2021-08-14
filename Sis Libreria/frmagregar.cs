using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmagregar : Form
    {
        public frmagregar()
        {
            InitializeComponent();
        }

        private void frmagregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea cerrar esta ventana", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private string operacion = string.Empty;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombrelibro.Text == "")
            {
                errorProvider1.SetError(txtnombrelibro, "Ingrese el Nombre del Libro");
                txtnombrelibro.Focus();
                return;
            }
            errorProvider1.SetError(txtnombrelibro, "");
            if (txtnautor.Text == "")
            {
                errorProvider1.SetError(txtnautor, "Ingrese el Autor del Libro");
                txtnautor.Focus();
                return;
            }
            errorProvider1.SetError(txtnautor, "");
            if (cbgenero.Text == "")
            {
                errorProvider1.SetError(cbgenero, "Ingrese el Género del Libro");
                cbgenero.Focus();
                return;
            }
            errorProvider1.SetError(cbgenero, "");

            //insertar en la base
            BaseDatos proyect = new BaseDatos();
            if (operacion == "Agregar")
            {
                proyect.insertarlibro(Convert.ToInt32(cbgenero.SelectedValue), txtnombrelibro.Text, txtnombrelibro.Text, txtnautor.Text);
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidlibro.Clear();
            txtnautor.Clear();
            txtnombrelibro.Clear();
        }

        private void frmagregar_Load(object sender, EventArgs e)
        {
            BaseDatos proyect = new BaseDatos();
            cbgenero.DataSource = proyect.cargargeneros();
            cbgenero.DisplayMember = "nombregenero";
            cbgenero.ValueMember = "idgenero";
        }
    }
}
