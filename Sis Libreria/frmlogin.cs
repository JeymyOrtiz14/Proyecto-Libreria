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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "")
            {
                errorProvider1.SetError(txtusuario, "Ingrese el Usuario");
                txtusuario.Focus();
                return;
            }
            errorProvider1.SetError(txtusuario, "");

            if (txtcontraseña.Text == "")
            {
                errorProvider1.SetError(txtcontraseña, "Ingrese la COntraseña");
                txtcontraseña.Focus();
                return;
            }
            errorProvider1.SetError(txtcontraseña, "");

            //conexion a base de datos
            string cadena = @"Data Source=JORTIZ\SQLEXPRESS;  database= sisbiblioteca; integrated security = true";
            bool usuariovalido = false;
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                string consulta = "select 1 from usuarios where username='" + txtusuario.Text + "'and clave='" + txtcontraseña.Text + "';";
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    usuariovalido = Convert.ToBoolean(comando.ExecuteScalar());
                }
            }

            if (usuariovalido)
            {
                MessageBox.Show("Bienvenido a la Libreria MMXXI");
                this.Hide();
                frmmenu frm = new frmmenu();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario / Contraseña Incorrecta");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar el programa", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
