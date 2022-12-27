using SISTotalControl.Entidades.Helpers;
using System.Data;

namespace SISTotalControl.Entidades.Modelos
{
    public class Rutas_archivos
    {
        public Rutas_archivos()
        {

        }
        public Rutas_archivos(DataRow row)
        {
            this.Id_ruta_archivo = ConvertValueHelper.ConvertirNumero(row["Id_ruta_archivo"]);
            this.Id_usuario = ConvertValueHelper.ConvertirNumero(row["Id_ruta_archivo"]);
            this.Tipo_archivo = ConvertValueHelper.ConvertirCadena(row["Tipo_archivo"]);
            this.Fecha_archivo = ConvertValueHelper.ConvertirFecha(row["Fecha_archivo"]);
            this.Hora_archivo = ConvertValueHelper.ConvertirHora(row["Hora_archivo"]);
            this.Ruta_archivo = ConvertValueHelper.ConvertirCadena(row["Ruta_archivo"]);
            this.Nombre_archivo = ConvertValueHelper.ConvertirCadena(row["Nombre_archivo"]);
            this.Extension_archivo = ConvertValueHelper.ConvertirCadena(row["Extension_archivo"]);
        }

        public int Id_ruta_archivo { get; set; }
        public int Id_usuario { get; set; }
        public string Tipo_archivo { get; set; }
        public DateTime Fecha_archivo { get; set; }
        public TimeSpan Hora_archivo { get; set; }
        public string Ruta_archivo { get; set; }
        public string Nombre_archivo { get; set; }
        public string Extension_archivo { get; set; }
    }
}
