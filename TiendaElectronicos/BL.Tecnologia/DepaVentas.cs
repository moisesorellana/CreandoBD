using BL.Tecnologia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class DepaVentas
    {

        Contexto _contexo;

        public BindingList<Vendedor> ListaVendedores{ get; set; }

        public DepaVentas()
        {
            _contexo = new Contexto();
            ListaVendedores = new BindingList<Vendedor>();


        }

        public BindingList<Vendedor> ObtenerClientes()
        {
            _contexo.Vendedores.Load();

            ListaVendedores = _contexo.Vendedores.Local.ToBindingList();

            return ListaVendedores;
        }
        public Respuesta GuardarVendedor(Vendedor vendedor)
        {
            var respuesta = Validar(vendedor);
            if (respuesta.Exitoso == false)
            {
                return respuesta;
            }
            _contexo.SaveChanges();

            if (vendedor.Id == 0)
            {
                vendedor.Id = ListaVendedores.Max(item => item.Id) + 1;
            }
            respuesta.Exitoso = true;
            return respuesta;
        }


        public void AgregarVendedor()
        {
            var nuevovendedor = new Vendedor();

            ListaVendedores.Add(nuevovendedor);
        }

        //


        public bool EliminarCliente(int Id)
        {

            foreach (var vendedor in ListaVendedores)
            {
                if (vendedor.Id == Id)
                {
                    ListaVendedores.Remove(vendedor);
                    return true;
                }
            }


            return false;
        }


           private Respuesta Validar(Vendedor vendedor)
                {
                   var respuesta = new Respuesta();
                   respuesta.Exitoso = true;

                  if (string.IsNullOrEmpty(vendedor.Nombre) == true)
                  {
                     respuesta.Mensaje = "Ingrese un Nombre";
                     respuesta.Exitoso = false;
                   }


                     if (string.IsNullOrEmpty(vendedor.Apellido) == true)
                     {
                        respuesta.Mensaje = "Ingrese un Apellido";
                        respuesta.Exitoso = false;
                 }

                   return respuesta;
        }

    }

    public class Vendedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
    
}
