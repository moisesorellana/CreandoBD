using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaElectronicos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            var formLogin = new FormLogin();           
            formLogin.ShowDialog();
        
        }

        private void atencionAlClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAtencionCliente = new FormAtencionAlCliente();
            formAtencionCliente.MdiParent = this;
            formAtencionCliente.Show();
        }

        private void enviosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEnvios = new FormEnvios();
            formEnvios.MdiParent = this;
            formEnvios.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVentas = new FormVentas();
            formVentas.MdiParent = this;
            formVentas.Show();
        }

        private void reporteVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteVentas = new FormReporteVentas();
            formReporteVentas.MdiParent = this;
            formReporteVentas.Show();
        }

        private void reporteComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteCompras = new FormReporteCompras();
            formReporteCompras.MdiParent = this;
            formReporteCompras.Show();
        }

        private void reporteInacistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteInacistencias = new FormReporteInacistencias();
            formReporteInacistencias.MdiParent = this;
            formReporteInacistencias.Show();
        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formProductos = new FormProductos();
            formProductos.MdiParent = this;
            formProductos.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }
    }
}
