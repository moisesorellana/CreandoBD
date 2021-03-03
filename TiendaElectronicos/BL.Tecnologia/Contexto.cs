using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class Contexto:DbContext
    {
        public Contexto(): base()
        {

        }
        public DbSet <Producto> Productos { get; set; }

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
