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
    public partial class FormUsuarios : Form
    {
        UsuarioBL _Usuario;
        public FormUsuarios()
        {
           
            InitializeComponent();

            _Usuario = new UsuarioBL();
            listaUsuarioBindingSource.DataSource = _Usuario.ObtenerUsuario();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _Usuario.AgregarUsuario();
            listaUsuarioBindingSource.MoveLast();

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

        private void Eliminar(int Id)
        {

            var Respuesta = _Usuario.EliminarUsuario(Id);

            if (Respuesta == true)
            {
                listaUsuarioBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void listaUsuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaUsuarioBindingSource.EndEdit();
            var usuario = (Usuario)listaUsuarioBindingSource.Current;

            var Resultado = _Usuario.GuardarUsuario(usuario);

            if (Resultado.Exitoso== true)
            {
                listaUsuarioBindingSource.ResetBindings(false);

                DesahibilarHabilitar(true);
                MessageBox.Show("Usuario Registrado");
            }
            else
            {
                MessageBox.Show(Resultado.Mensaje);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DesahibilarHabilitar(true);
            Eliminar(0);
        }
    }
}

