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
        public Contexto(): base("Tecno")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }

        public DbSet <Producto> Productos { get; set; }
        public DbSet <Categoria> Categorias { get; set; }
        



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
