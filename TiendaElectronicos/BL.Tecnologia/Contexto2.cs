using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Tecnologia
{
    public class Contexto2: DbContext
    {
        public Contexto2(): base ("Clientes")
        {

        }

        public DbSet <Cliente> Clientes { get; set; }
    }
}
