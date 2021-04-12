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

        private void generalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formClientes = new FormClientes();
            formClientes.MdiParent = this;
            formClientes.Show();
        }

        private void mayoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMayorista = new FormMayoristas();
            formMayorista.MdiParent = this;
            formMayorista.Show();
        }

        private void exclusivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formExclusivo = new FormExclusivo();
            formExclusivo.MdiParent = this;
            formExclusivo.Show();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEntradas = new FormEntradas();
            formEntradas.MdiParent = this;
            formEntradas.Show();

        }

        private void salidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formSalidas = new FormSalidas();
            formSalidas.MdiParent = this;
            formSalidas.Show();

        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFacturas = new FormFacturas();
            formFacturas.MdiParent = this;
            formFacturas.Show();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var formVendedor = new FormVendedores();
            formVendedor.MdiParent = this;
            formVendedor.Show();
        }

        private void reporteProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteProduto = new FormReporteProductos();
            formReporteProduto.MdiParent = this;
            formReporteProduto.Show();
        }
    }
}
