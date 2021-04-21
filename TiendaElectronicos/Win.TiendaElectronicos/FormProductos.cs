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
    public partial class FormProductos : Form
    {
        ProductosBL Productos;
        CategoriaBL Categorias;

        public FormProductos()
        {
            InitializeComponent();

            Productos = new ProductosBL();

            listaProductoBindingSource.DataSource = Productos.ObtenerProductos();

            Categorias = new CategoriaBL();
            listaCategoriaBindingSource.DataSource = Categorias.ObtenerCategoria();
        }

        private void listaProductosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

            listaProductoBindingSource.EndEdit();
            var producto = (Producto)listaProductoBindingSource.Current;


            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }
            var Resultado = Productos.GuardarProducto(producto);

            if (Resultado.Correcto == true)
            {
                listaProductoBindingSource.ResetBindings(false);
                HabilitarDeshabilitar(true);
                MessageBox.Show("Producto Registrado");
            }
            else
            {
                MessageBox.Show(Resultado.Incorrecto);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Productos.AgregarProducto();
            listaProductoBindingSource.MoveLast();

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

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea Elminar Este Producto ?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var Id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(Id);
                }

            }
        }

        private void Eliminar(int id)
        {

            var Resultado = Productos.Eliminar(id);

            if (Resultado == true)
            {
                listaProductoBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Error al Eliminar Producto");
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HabilitarDeshabilitar(true);
            Eliminar(0);
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Categoria' Puede moverla o quitarla según sea necesario.
            this.categoriaTableAdapter.Fill(this.dataSet1.Categoria);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.dataSet1.Producto);

        }

        private void IdLabel_Click(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void listaProductosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fotoLabel_Click(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductoBindingSource.Current;
            if (producto != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStrem = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(fileStrem);
                }
            }
            else
            {
                MessageBox.Show("no se puede asignar imagen sin Antes Regitrar un producto");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                var buscar = textBox1.Text;
                listaProductoBindingSource.DataSource = Productos.ObtenerProductos(buscar);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void activoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void activoLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

}

