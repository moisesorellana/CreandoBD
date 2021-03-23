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
    public class ClientesBL
    {

        Contexto _contexo;

        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexo = new Contexto();
            ListaClientes = new BindingList<Cliente>();

              
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexo.Clientes.Load();

            ListaClientes = _contexo.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public Respuesta GuardarCliente(Cliente cliente)
        {
            var respuesta = Validar(cliente);
            if(respuesta.Exitoso == false)
            {
                return respuesta;
            }
            _contexo.SaveChanges();

            if(cliente.Id == 0)
            {
                cliente.Id = ListaClientes.Max(item => item.Id) + 1;
            }
            respuesta.Exitoso = true;
            return respuesta;
        }

        public void AgregarCliente()
        {
            var nuevocliente = new Cliente();

            ListaClientes.Add(nuevocliente);
        }

        public bool EliminarCliente(int Id)
            {

                 foreach (var cliente in ListaClientes)
                 {
                   if(cliente.Id == Id )
                    {
                       ListaClientes.Remove(cliente);
                       return true;
                    }
                 }


                 return false;
            }

        private Respuesta Validar (Cliente cliente)
        {
            var respuesta = new Respuesta();
            respuesta.Exitoso = true;



            if (cliente == null)
            {
                respuesta.Mensaje = "Agregue un Cliente Valido";
                respuesta.Exitoso = false;

                return respuesta;
            }

            if (string.IsNullOrEmpty(cliente.Nombre)== true)
            {
                respuesta.Mensaje = "Ingrese un Nombre";
                respuesta.Exitoso = false;
            }


            if (string.IsNullOrEmpty(cliente.Apellido)== true)
            {
                respuesta.Mensaje = "Ingrese un Apellido";
                respuesta.Exitoso = false;
            }

            if (string.IsNullOrEmpty(cliente.Add)== true)
            {
                respuesta.Mensaje = "Ingrese una Direccion";
                respuesta.Exitoso = false;
            }



            return respuesta;
        }
       
    }

    public class Cliente
    {
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Add { get; set; }
        public double Telefono{ get; set; }
        public string TipoCliente { get; set; }
        public byte[] Foto { get; set; }
        public double RTN { get; set; }
    }

    public class Respuesta
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
