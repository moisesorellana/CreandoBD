using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class ProductosBL
    {
        contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new contexto();
            ListaProductos = new BindingList<Producto>();


        }

        public BindingList<Producto> ObtenerProductos()
        {

            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }

        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if (resultado.Exitoso == false )
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }

        private Resultado Validar (Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (producto.Precio < 50)
            {
                resultado.Mensaje = "El precio debe ser mayor o igual que cincuenta ";
                resultado.Exitoso = false;
            }
            if (producto.Inventario < 1)
            {
                resultado.Mensaje = "El inventario debe ser mayor que cero ";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

    public class Producto
    {
        public int id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int Inventario { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado
    {
    public bool Exitoso { get; set; }
    public string Mensaje { get; set; }
    }
}
