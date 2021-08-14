using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void préstamoLibroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmprestamo prestamo = new frmprestamo();
            prestamo.MdiParent = this;
            prestamo.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmreporte reporte = new frmreporte();
            reporte.MdiParent = this;
            reporte.Show();
        }
    }
}
