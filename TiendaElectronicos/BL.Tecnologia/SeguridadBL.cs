using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class SeguridadBL
    {
        Contexto _contexto;

        public SeguridadBL()
        {
            _contexto = new Contexto();
        }


        public Usuario Autorizar(string Usuario, string Contraseña)
        {

            var Usuarios = _contexto.Usuarios.ToList();

            foreach(var usuarioBD in Usuarios)
            {
                if(Usuario == usuarioBD.Nombre && Contraseña == usuarioBD.Contraseña)
                {
                    return usuarioBD;
                }
            }
            return null;
           
        }

    }
}
