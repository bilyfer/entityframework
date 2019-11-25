using System;
using System.Data.Entity;
using System.IO;

namespace AppBL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";

            contexto.Usuarios.Add(usuarioAdmin);

            var archivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\100 Sales Records.csv";
            using (var reader = new StreamReader(archivo))
            {
                reader.ReadLine(); // Lee primera fila de encabezados

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    var nuevaVenta = new Ventas()
                    {
                        Region = values[0].ToString(),
                        Country = values[1].ToString(),
                        ItemType = values[2].ToString(),
                        SalesChannel = values[3].ToString(),
                        OrderPriority = values[4].ToString(),
                        OrderDate = DateTime.Parse(values[5].ToString()),
                        OrderId = values[6].ToString(),
                        ShipDate = DateTime.Parse(values[7].ToString()),
                        UnitSold = int.Parse(values[8].ToString()),
                        UnitPrice = decimal.Parse(values[9].ToString()),
                        UnitCost = decimal.Parse(values[10].ToString()),
                        TotalRevenue = decimal.Parse(values[11].ToString()),
                        TotalCost = decimal.Parse(values[12].ToString()),
                        TotalProfit = decimal.Parse(values[13].ToString())
                    };
                    contexto.Ventas.Add(nuevaVenta);
                }
            }

            base.Seed(contexto);
        }
    }
}
