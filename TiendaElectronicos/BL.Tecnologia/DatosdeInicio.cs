using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var UsuarioMoises = new Usuario();
            UsuarioMoises.Nombre = "Moises";
            UsuarioMoises.Contraseña = "1470";
            contexto.Usuarios.Add(UsuarioMoises);

            var UsuarioNoelia= new Usuario();
            UsuarioNoelia.Nombre = "Noelia";
            UsuarioNoelia.Contraseña = "123";
            contexto.Usuarios.Add(UsuarioNoelia);

            var UsuarioJuan = new Usuario();
            UsuarioJuan.Nombre = "Juan";
            UsuarioJuan.Contraseña = "456";
            contexto.Usuarios.Add(UsuarioJuan);


            var categoria1 = new Categoria();
            categoria1.Descripcion = "Reloj";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Televisor";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Computadoras";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Camaras";
            contexto.Categorias.Add(categoria4);

          


            base.Seed(contexto);
            
        }
    }

}
