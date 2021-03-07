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

        Contexto2 _contexto;

        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto2();
            ListaClientes = new BindingList<Cliente>();

              
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public Respuesta GuardarCliente(Cliente cliente)
        {
            var respuesta = Validar(cliente);
            if(respuesta.Exitoso == false)
            {
                return respuesta;
            }
            if(cliente.IdCustumer == 0)
            {
                cliente.IdCustumer = ListaClientes.Max(item => item.IdCustumer) + 1;
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
                   if(cliente.IdCustumer == Id )
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

            if (string.IsNullOrEmpty(cliente.Name)== true)
            {
                respuesta.Mensaje = "Ingrese un Nombre";
                respuesta.Exitoso = false;
            }


            if (string.IsNullOrEmpty(cliente.LastName)== true)
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
        public int IdCustumer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Add { get; set; }
        public double Telephone{ get; set; }
    }

    public class Respuesta
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
