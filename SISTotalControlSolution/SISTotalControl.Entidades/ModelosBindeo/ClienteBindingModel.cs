using SISTotalControl.Entidades.Modelos;
using System.Data;

namespace SISTotalControl.Entidades.ModelosBindeo
{
    public class ClienteBindingModel
    {
        public ClienteBindingModel()
        {

        }

        public ClienteBindingModel(DataRow row)
        {
            try
            {
                this.Usuario = new Usuarios(row);
                this.Direccion_cliente = new Direccion_clientes(row);
                this.Venta = new Ventas(row);
                this.Agendamiento = new Agendamiento_cobros(row);
            }
            catch (Exception)
            {

            }
        }

        public Usuarios Usuario { get; set; }
        public Direccion_clientes Direccion_cliente { get; set; }
        public Ventas Venta { get; set; }
        public Agendamiento_cobros Agendamiento { get; set; }
        public List<string> Imagenes { get; set; }
        public string TotalVista => $"Total venta: {Venta.Total_venta:N2}";
    }
}
