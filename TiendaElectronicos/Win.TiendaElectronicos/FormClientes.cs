using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.TiendaElectronicos
{
    public partial class FormClientes : Form
    {

        ClientesBL _Clientes;
        public FormClientes()
        {
            InitializeComponent();

            _Clientes = new ClientesBL();
            clienteBindingSource.DataSource = _Clientes.ObtenerClientes();
        }

        private void clienteBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void addTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            clienteBindingSource.EndEdit();
            var cliente = (Cliente)clienteBindingSource.Current;

            if(fotoPictureBox != null)
            {
                cliente.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                cliente.Foto = null;
            }

            var respuesta = _Clientes.GuardarCliente(cliente);

            if (respuesta.Exitoso == true)
            {
                clienteBindingSource.ResetBindings(false);
                DesahibilarHabilitar(true);
                MessageBox.Show("Cliente Registrado Exitosamente");
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Clientes.AgregarCliente();
            clienteBindingSource.MoveLast();

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

            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text != "")
            {
                var Id = Convert.ToInt32(idTextBox.Text);
                Eliminar(Id);
            }
            
        }

        private void Eliminar(int Id)
        {

            var Respuesta = _Clientes.EliminarCliente(Id);

            if (Respuesta== true)
            {
                clienteBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DesahibilarHabilitar(true);
            Eliminar(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)clienteBindingSource.Current;
            if(cliente != null )
            {
                openFileDialog1.ShowDialog();
                var Archivo = openFileDialog1.FileName;

                if (Archivo != "")
                {
                    var fileInfo = new FileInfo(Archivo);
                    var fileStrem = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStrem);
                }
            }
            else
            {
                MessageBox.Show("Ingrese los Datos completos del Cliente");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
