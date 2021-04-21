using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
   public class UsuarioBL
    {
        Contexto _contexo;

        public BindingList<Usuario> ListaUsuario { get; set; }

        public UsuarioBL()
        {
            _contexo = new Contexto();
            ListaUsuario = new BindingList<Usuario>();


        }

        public BindingList<Usuario> ObtenerUsuario()
        {
            _contexo.Usuarios.Load();

            ListaUsuario = _contexo.Usuarios.Local.ToBindingList();

            return ListaUsuario;
        }

        public Respuesta GuardarUsuario(Usuario usuario)
        {
            var respuesta = Validar(usuario);
            if (respuesta.Exitoso == false)
            {
                return respuesta;
            }
            _contexo.SaveChanges();

            if (usuario.Id == 0)
            {
                usuario.Id = ListaUsuario.Max(item => item.Id) + 1;
            }
            respuesta.Exitoso = true;
            return respuesta;
        }

        public void AgregarUsuario()
        {
            var nuevoUsuario = new Usuario();

            ListaUsuario.Add(nuevoUsuario);
        }

        public bool EliminarUsuario(int Id)
        {

            foreach (var usuario in ListaUsuario)
            {
                if (usuario.Id == Id)
                {
                    ListaUsuario.Remove(usuario);
                    return true;
                }
            }


            return false;
        }

        private Respuesta Validar(Usuario usuario)
        {
            var respuesta = new Respuesta();
            respuesta.Exitoso = true;



            if (usuario == null)
            {
                respuesta.Mensaje = "Agregue un Usuario Valido";
                respuesta.Exitoso = false;

                return respuesta;
            }

            if (string.IsNullOrEmpty(usuario.Nombre) == true)
            {
                respuesta.Mensaje = "Ingrese un Nombre";
                respuesta.Exitoso = false;
            }


            if (string.IsNullOrEmpty(usuario.Apellido) == true)
            {
                respuesta.Mensaje = "Ingrese un Apellido";
                respuesta.Exitoso = false;
            }

            if (string.IsNullOrEmpty(usuario.Contraseña) == true)
            {
                respuesta.Mensaje = "Contraseña Incorrecta";
                respuesta.Exitoso = false;
            }



            return respuesta;
        }




    }

    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Contraseña { get; set; }

    }
}
