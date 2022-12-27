using SISTotalControl.Entidades.Helpers;
using System.Data;

namespace SISTotalControl.Entidades.Modelos
{
    public class Stock_productos
    {
        public Stock_productos()
        {

        }

        public Stock_productos(DataRow row)
        {
            this.Id_stock = ConvertValueHelper.ConvertirNumero(row["Id_stock"]);
            this.Id_producto = ConvertValueHelper.ConvertirNumero(row["Id_producto"]);
            this.Fecha_stock = ConvertValueHelper.ConvertirFecha(row["Fecha_stock"]);
            this.Hora_stock = ConvertValueHelper.ConvertirHora(row["Hora_stock"]);
            this.Cantidad_stock = ConvertValueHelper.ConvertirDecimal(row["Cantidad_stock"]);
            this.Observaciones_producto = ConvertValueHelper.ConvertirCadena(row["Observaciones_producto"]);
        }

        public int Id_stock { get; set; }
        public int Id_producto { get; set; }
        public DateTime Fecha_stock { get; set; }
        public TimeSpan Hora_stock { get; set; }
        public decimal Cantidad_stock { get; set; }
        public string Observaciones_producto { get; set; }

        public string Cantidad_vista
        {
            get
            {
                return $"Stock {this.Cantidad_stock:N}";
            }
        }

        public string Fecha_ultimo_stock
        {
            get
            {
                return $"Última actualización {this.Fecha_stock:yyyy-MM-dd}";
            }
        }
    }
}
