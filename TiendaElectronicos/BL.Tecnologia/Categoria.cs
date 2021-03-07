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
    public  class CategoriaBL
    {
        Contexto _contexto;
        
        public BindingList<Categoria> ListaCategoria { get; set; }

        public CategoriaBL()
        {
            _contexto = new Contexto();
            ListaCategoria = new BindingList<Categoria>();
        }
        public BindingList<Categoria> ObtenerCategoria()
        {
            _contexto.Categorias.Load();
            ListaCategoria = _contexto.Categorias.Local.ToBindingList();
            return ListaCategoria;
        }
    }

    public class Categoria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
