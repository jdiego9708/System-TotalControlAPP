namespace SISTotalControl.Entidades.Modelos
{
    using SISTotalControl.Entidades.Helpers;
    using System;
    using System.Data;

    public class Articulos
    {
        public Articulos()
        {

        }

        public Articulos(DataRow row)
        {
            try
            {
                this.Id_articulo = ConvertValueHelper.ConvertirNumero(row["Id_articulo"]);
                this.Referencia_articulo = ConvertValueHelper.ConvertirCadena(row["Referencia_articulo"]);
                this.Descripcion_articulo = ConvertValueHelper.ConvertirCadena(row["Descripcion_articulo"]);
                this.Tipo_cantidad = ConvertValueHelper.ConvertirCadena(row["Tipo_cantidad"]);
                this.Cantidad_articulo = ConvertValueHelper.ConvertirDecimal(row["Cantidad_articulo"]);
                this.Valor_articulo = ConvertValueHelper.ConvertirDecimal(row["Valor_articulo"]);
                this.Estado_articulo = ConvertValueHelper.ConvertirCadena(row["Estado_articulo"]);
            }
            catch (Exception)
            {

            }
        }

        public int Id_articulo { get; set; }

        public string Referencia_articulo { get; set; }

        public string Descripcion_articulo { get; set; }

        public string Tipo_cantidad { get; set; }

        public decimal Cantidad_articulo { get; set; }

        public decimal Valor_articulo { get; set; }

        public string Estado_articulo { get; set; }    
    }
}
