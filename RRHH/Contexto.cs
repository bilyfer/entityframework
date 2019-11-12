using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH
{
    public class Contexto: DbContext
    {
        public Contexto() : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDBFilename=" +
            Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\QuieroPizzaDB.mdf")
        {

        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
