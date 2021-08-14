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
    public partial class frmreporte : Form
    {
        public frmreporte()
        {
            InitializeComponent();
        }

        private void btngenerar_Click(object sender, EventArgs e)
        {
            reporte();
        }

        void reporte()
        {
            string cadena = @"Data Source=JORTIZ\SQLEXPRESS;  database= sisbiblioteca; integrated security = true";
            using (SqlConnection conn1 = new SqlConnection(cadena))
            {
                try
                {
                    SqlCommand comando = new SqlCommand("select * from libro", conn1);
                    conn1.Open();
                    SqlDataReader leer = comando.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            dgreporte.Rows.Add(leer.GetString(0), leer.GetString(1), leer.GetString(2), leer.GetString(3), leer.GetString(4));
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para leer");
                    }
                    conn1.Close();
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
        }
    }
}
