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
    public partial class FormVendedores : Form
    {
        DepaVentas _Vendedor;
        public FormVendedores()
        {
            InitializeComponent();

            _Vendedor = new DepaVentas();
            vendedorBindingSource.DataSource = _Vendedor.ObtenerClientes();
        }

        private void FormVendedores_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Vendedor.AgregarVendedor();
            vendedorBindingSource.MoveLast();

            DesahibilarHabilitar(false);
        }


        private void DesahibilarHabilitar(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;

           
        }


        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "")
            {
                var Id = Convert.ToInt32(idTextBox.Text);
                Eliminar(Id);
            }

        }

        private void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        private void vendedorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            vendedorBindingSource.EndEdit();
            var vendedor = (Vendedor)vendedorBindingSource.Current;


            var respuesta = _Vendedor.GuardarVendedor(vendedor);

            if (respuesta.Exitoso == true)
            {
                
                DesahibilarHabilitar(true);
                MessageBox.Show("Vendedor Registrado Exitosamente");
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DesahibilarHabilitar(true);
            Eliminar(0);
        }
    }
}
