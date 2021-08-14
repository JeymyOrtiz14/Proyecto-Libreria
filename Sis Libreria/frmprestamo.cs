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
using System.IO;
using System.Data.SqlClient;
using System.Net;

namespace WindowsFormsApp1
{
    public partial class frmprestamo : Form
    {
        public frmprestamo()
        {
            InitializeComponent();
        }


        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarlibros();
            btnadquirir.Enabled = true;
            btnborrar.Enabled = true;
            btndevoluciòn.Enabled = true;

            if (txtautor.Text == "")
            {
                MessageBox.Show("Introduzca el ID del libro");
            }
        }

        void buscarlibros()
        {
            string cadena = @"Data Source=JORTIZ\SQLEXPRESS;  database= sisbiblioteca; integrated security = true";
            var idlibro = txtbuscar.Text.Trim();
            using (SqlConnection conn1 = new SqlConnection(cadena))
                try
                {
                    SqlCommand comando = new SqlCommand("Select * from libro where idcodigo like'" + idlibro + "%'", conn1);
                    conn1.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            if (txtbuscar.Text == leer.GetString(0))
                            {
                                txtgenero.Text = leer.GetString(1);
                                txtnombrelibro.Text = leer.GetString(2);
                                txtautor.Text = leer.GetString(3);
                                txtestado.Text = leer.GetString(4);
                            }
                            else
                            {
                                MessageBox.Show("El libro no esta disponible");
                            }
                        }
                    }
                    conn1.Close();
                }
                catch (System.Exception error)
                {

                    MessageBox.Show("Existe error en el proceso de seleccionar libros " + error.Message);
                }
                finally
                {
                    conn1.Close();
                }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmprestamo_Load(object sender, EventArgs e)
        {
            btnadquirir.Enabled = false;
            btnborrar.Enabled = false;
            btndevoluciòn.Enabled = false;
        }

        private void txtbuscar_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btnadquirir_Click(object sender, EventArgs e)
        {
            if (txtestado.Text == "Préstamo")
            {
                MessageBox.Show("El libro que solicita no esta disponible");
                return;
            }
            else
            {
                adquirir();
            }
           
        }

        void adquirir()
        { 
            txtestado.Text = "Préstamo";
            string cadena = @"Data Source=JORTIZ\SQLEXPRESS;  database= sisbiblioteca; integrated security = true";
            using (SqlConnection conn1 = new SqlConnection(cadena))
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("¿DESEA ADQUIRIR EL LIBRO SELECIONADO?", "Confirmar mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var sql = @"update libro set estado='" + txtestado.Text + "' where idcodigo like'" + txtbuscar.Text + "%'";
                        var cmd = new SqlCommand(sql, conn1);
                        conn1.Open();
                        var x = cmd.ExecuteNonQuery();
                        conn1.Close();
                        MessageBox.Show("EL PRÈSTAMO HA SIDO REALIZADO SATISFACTORIAMENTE...");
                    }
                    else
                    {
                        txtestado.Text = "Disponible";
                    }
                }
                catch (System.Exception error)
                {

                    MessageBox.Show("Error " + error.Message);
                }
                finally
                {
                    conn1.Close();
                }
        }
        private void btnborrar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("¿DESEA BUSCAR OTRO LIBRO?", "Confirmar mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                txtbuscar.Clear();
                txtautor.Clear();
                txtnombrelibro.Clear();
                txtgenero.Clear();
                txtestado.Clear();
                btnadquirir.Enabled = false;
                btndevoluciòn.Enabled = false;
                btnborrar.Enabled = false;
            }
            else
            {
                this.Close();
            }
        }
        
        private void btndevoluciòn_Click(object sender, EventArgs e)
        {
            if (txtestado.Text=="Disponible")
            {
                MessageBox.Show("El libro ya esta en la libreria veirfique bien los datos");
            }
            else
            {
                devolucion();
            }

        }
        void devolucion()
        {
            txtestado.Text = "Disponible";
            string cadena = @"Data Source=JORTIZ\SQLEXPRESS;  database= sisbiblioteca; integrated security = true";
            using (SqlConnection conn1 = new SqlConnection(cadena))
                try
                {
                    DialogResult result;
                    result = MessageBox.Show("¿DESEA DEVOLVER EL LIBRO SELECIONADO?", "Confirmar mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        var sql = @"update libro set estado= '" + txtestado.Text + "' where idcodigo like'" + txtbuscar.Text + "%'";
                        var cmd = new SqlCommand(sql, conn1);
                        conn1.Open();
                        var x = cmd.ExecuteNonQuery();
                        conn1.Close();
                        MessageBox.Show("LA DEVOLUCIóN HA SIDO REALIZADO SATISFACTORIAMENTE...");
                    }
                    else
                    {
                        txtestado.Text = "Préstamo";
                    }

                }
                catch (System.Exception error)
                {
                    MessageBox.Show("exite error en el proceso " + error.Message);
                }
                finally
                {
                    conn1.Close();
                }
        }
    }
}
