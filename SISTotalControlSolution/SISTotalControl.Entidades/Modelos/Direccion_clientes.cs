﻿namespace SISTotalControl.Entidades.Modelos
{
    using SISTotalControl.Entidades.Helpers;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data;
    

    public class Direccion_clientes
    {
        public Direccion_clientes()
        {

        }

        public Direccion_clientes(DataRow row)
        {
            try
            {
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_usuario = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);               
                this.Direccion = ConvertValueHelper.ConvertirCadena(row["Direccion"]);
                this.Estado_dirección = ConvertValueHelper.ConvertirCadena(row["Estado_dirección"]);
                this.Id_zona = ConvertValueHelper.ConvertirNumero(row["Id_zona"]);
                

                this.Usuario = new Usuarios(row);
                this.Zona = new Zonas(row);
            }
            catch (Exception)
            {

            }
        }

        [Key]
        public int Id_direccion { get; set; }
        public int Id_usuario { get; set; }       
        public Usuarios Usuario { get; set; }
        public int Id_zona { get; set; }       
        public Zonas Zona { get; set; }
        public string Direccion { get; set; }
        public string Estado_dirección { get; set; } = "ACTIVO";

        public string DireccionRecortada
        {
            get
            {
                if (Direccion.Length > 30)
                {
                    string nuevaDireccion = Direccion[..27] + "...";
                    return nuevaDireccion;
                }
                
                return Direccion;
            }
        }
    }
}
