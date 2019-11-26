
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;

namespace AppBL
{
    public class VentasBL
    {
        Contexto _contexto;

        public BindingList<Ventas> ListadeVentas { get; set; }

        public VentasBL()
        {
            _contexto = new Contexto();
        }

        public BindingList<Ventas> ObtenerVentas()
        {
            _contexto.Ventas.Load();
            ListadeVentas = _contexto.Ventas.Local.ToBindingList();

            return ListadeVentas;
        }
    }
}
