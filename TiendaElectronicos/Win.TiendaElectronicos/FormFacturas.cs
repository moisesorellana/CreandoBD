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
    public partial class FormFacturas : Form
    {
        FacturaBL _facturaBL;
        ClientesBL _clientesBL;
        ProductosBL _productosBL;
       
        public FormFacturas()
        {
            InitializeComponent();

            _facturaBL = new FacturaBL();
            facturaBindingSource.DataSource = _facturaBL.ObtenerFacturas();

            _clientesBL = new ClientesBL();
            listaClientesBindingSource.DataSource = _clientesBL.ObtenerClientes();

            _productosBL = new ProductosBL();
            productosBLBindingSource.DataSource = _productosBL.ObtenerProductos();

            
        }

        private void FormFacturas_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL.AgregarFactura();
            facturaBindingSource.MoveLast();

            HabilitarDeshabilitar(false);
        }


        private void HabilitarDeshabilitar(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;


            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

            toolStripButton1.Visible = !valor;

        }

        private void facturaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            facturaBindingSource.EndEdit();

            var factura = (Factura)facturaBindingSource.Current;

            var resultado = _facturaBL.GuardarFactura(factura);

            if(resultado.Correcto == true )
            {
                facturaBindingSource.ResetBindings(false);
                HabilitarDeshabilitar(true);

                MessageBox.Show("Facturado");
            }
            else
            {
                MessageBox.Show(resultado.Incorrecto);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(true);
            _facturaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;
            _facturaBL.AgregarFactura(factura);
            HabilitarDeshabilitar(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;
            var facturaDetalle = (FacturaDetalle)facturaDetalleBindingSource.Current;

            _facturaBL.RemoverFacturaDetalle(factura, facturaDetalle);

            HabilitarDeshabilitar(false);
        }

        private void facturaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            e.ThrowException = false;
        }

        private void facturaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura = (Factura)facturaBindingSource.Current;
            _facturaBL.CalcularFactura(factura);

            facturaBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Anular la Factura", "Anular", MessageBoxButtons.YesNo);

                if(resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturaBL.AnularFactura(id);

            if(resultado == true)
            {
                facturaBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un Error a Anular la Factura");
            }
        }

        private void facturaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

            var factura = (Factura)facturaBindingSource.Current;

            if(factura != null && factura.Id !=0 && factura.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}
