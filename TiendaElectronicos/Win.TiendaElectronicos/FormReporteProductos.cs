using BL.Tecnologia;
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
    public partial class FormReporteProductos : Form
    {
        public FormReporteProductos()
        {
            InitializeComponent();

            var _ProductoBL = new ProductosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _ProductoBL.ObtenerProductos();

            var reporte = new ReporteProducto();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();

        }
    }
}
