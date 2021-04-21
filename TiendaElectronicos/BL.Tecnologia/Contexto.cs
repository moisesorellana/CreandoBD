using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class Contexto:DbContext
    {
        public Contexto(): base("Tecnologia_MoisesOrellana_Equipo7")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet <Producto> Productos { get; set; }
        public DbSet <Categoria> Categorias { get; set; }
        public DbSet <Factura> Facturas { get; set; }
        public DbSet <Cliente> Clientes { get; set; }
        public DbSet <Vendedor> Vendedores { get; set;}
        public DbSet <Usuario> Usuarios { get; set; }
        
          



        internal static void DbContex()
        {
            throw new NotImplementedException();
        }

        internal static void DbContexSaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
