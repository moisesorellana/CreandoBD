using BL.Tecnologia;
using System;
using System.Collections;
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
        Contexto _contexto;
        public BindingList<Producto> ListaProducto { get; set; }

        public ProductosBL()
        {

            _contexto = new Contexto();
            ListaProducto = new BindingList<Producto>();
        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProducto =  _contexto.Productos.Local.ToBindingList();
            return ListaProducto;
        }

        public Resultado GuardarProducto(Producto Producto)
        {
            var resultado = validar(Producto);
            if( resultado.Correcto == false)
            {
              
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Correcto = true;
            return resultado;

            
        }



        public void AgregarProducto()
        {
            var NuevoProducto = new Producto();
            ListaProducto.Add(NuevoProducto);

        }

        public bool Eliminar(int id)
        {
            foreach (var Producto in ListaProducto)
            {
                if (Producto.Id == id)
                {
                    ListaProducto.Remove(Producto);
                    _contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }


        private Resultado validar(Producto Producto)
        {
            var resultado = new Resultado();
            resultado.Correcto = true;

            if(Producto == null)
            {
                resultado.Incorrecto = "Agregue un Producto Valido";
                resultado.Correcto = false;

                return resultado;
            }

            if(string.IsNullOrEmpty(Producto.Descripcion) == true )
            {
                resultado.Incorrecto = "Ingrese un Producto";
                resultado.Correcto = false;
            }

            if (Producto.Inventario <=0)
            {
                resultado.Incorrecto = "El Producto debe ser mayor a cero";
                resultado.Correcto = false;
            }

            if (Producto.Precio <=0)
            {
                resultado.Incorrecto = "El Producto debe contener un Precio mayor a cero";
                resultado.Correcto = false;
            }


            if (Producto.CategoriaId == 0)
            {
                resultado.Incorrecto = "Seleccione una Categoria";
                resultado.Correcto = false;
            }

            return resultado;
        }
    }


    public class Producto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public double Precio { get; set; }
        public int Inventario { get; set; }
        public byte[] Foto{ get; set; }
        public bool Activo { get; set; }


        public Producto()
        {
            Activo = true;
        }
    }

    

    public class Resultado
    {
      public bool Correcto{ get; set;}
      public string Incorrecto { get; set;}
    }
}
