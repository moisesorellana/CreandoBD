using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class SeguridadBL
    {
        public bool Autorizar(string Usuario, string Contraseña)
        {
            if(Usuario == "Empleado1"  && Contraseña == "123")
            {
                return true;
            }
            else
            {
                if(Usuario == "Empleado2" && Contraseña == "321")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
