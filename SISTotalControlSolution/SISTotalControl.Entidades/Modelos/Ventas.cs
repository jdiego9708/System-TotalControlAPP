namespace SISTotalControl.Entidades.Modelos
{
    using SISTotalControl.Entidades.Helpers;
    using SISTotalControl.Entidades.ModelosBindeo;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;

    public class Ventas
    {

        #region CONSTRUCTORES
        public Ventas()
        {

        }
        public Ventas(DataRow row)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = new Usuarios(row);
                this.Direccion = new Direccion_clientes(row);
                this.Cobro = new Cobros(row);
                this.Tipo_producto = new Tipo_productos(row);
                this.Turno = new Turnos(row);
            }
            catch (Exception)
            {

            }
        }
        public Ventas(DataRow row, Usuarios us)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = us;
                this.Direccion = new Direccion_clientes(row);
                this.Cobro = new Cobros(row);
                this.Tipo_producto = new Tipo_productos(row);
                this.Turno = new Turnos(row);
            }
            catch (Exception)
            {

            }
        }
        public Ventas(DataRow row, Usuarios usuario, Direccion_clientes direccion)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = usuario;
                this.Direccion = direccion;
                this.Cobro = new Cobros(row);
                this.Tipo_producto = new Tipo_productos(row);
                this.Turno = new Turnos(row);
            }
            catch (Exception)
            {

            }
        }
        public Ventas(DataRow row, Usuarios usuario, Direccion_clientes direccion, Cobros cobro)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = usuario;
                this.Direccion = direccion;
                this.Cobro = cobro;
                this.Tipo_producto = new Tipo_productos(row);
                this.Turno = new Turnos(row);
            }
            catch (Exception)
            {

            }
        }
        public Ventas(DataRow row, Usuarios usuario, Direccion_clientes direccion, Cobros cobro, Tipo_productos tipo)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = usuario;
                this.Direccion = direccion;
                this.Cobro = cobro;
                this.Tipo_producto = tipo;
                this.Turno = new Turnos(row);
            }
            catch (Exception)
            {

            }
        }
        public Ventas(DataRow row, Usuarios usuario, Direccion_clientes direccion, Cobros cobro, Tipo_productos tipo, Turnos turno)
        {
            try
            {
                this.Id_venta = ConvertValueHelper.ConvertirNumero(row["Id_venta"]);
                this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
                this.Id_tipo_producto = ConvertValueHelper.ConvertirNumero(row["Id_tipo_producto"]);
                this.Id_cliente = ConvertValueHelper.ConvertirNumero(row["Id_usuario"]);
                this.Id_direccion = ConvertValueHelper.ConvertirNumero(row["Id_direccion"]);
                this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
                this.Fecha_venta = ConvertValueHelper.ConvertirFecha(row["Fecha_venta"]);
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ConvertValueHelper.ConvertirHora(row["Hora_venta"]);
                this.Valor_venta = ConvertValueHelper.ConvertirDecimal(row["Valor_venta"]);
                this.Interes_venta = ConvertValueHelper.ConvertirDecimal(row["Interes_venta"]);
                this.Total_venta = ConvertValueHelper.ConvertirDecimal(row["Total_venta"]);
                this.Numero_cuotas = ConvertValueHelper.ConvertirNumero(row["Numero_cuotas"]);
                this.Frecuencia_cobro = ConvertValueHelper.ConvertirCadena(row["Frecuencia_cobro"]);
                this.Valor_cuota = ConvertValueHelper.ConvertirDecimal(row["Valor_cuota"]);
                this.Estado_venta = ConvertValueHelper.ConvertirCadena(row["Estado_venta"]);
                this.Tipo_venta = ConvertValueHelper.ConvertirCadena(row["Tipo_venta"]);

                this.Cliente = usuario;
                this.Direccion = direccion;
                this.Cobro = cobro;
                this.Tipo_producto = tipo;
                this.Turno = turno;
            }
            catch (Exception)
            {

            }
        }
        public Ventas(Ventas ve, Usuarios usuario, Direccion_clientes direccion, Cobros cobro, Tipo_productos tipo, Turnos turno)
        {
            try
            {
                this.Id_venta = ve.Id_venta;
                this.Id_cobro = ve.Id_cobro;
                this.Id_tipo_producto = ve.Id_tipo_producto;
                this.Id_cliente = ve.Id_cliente;
                this.Id_direccion = ve.Id_direccion;
                this.Id_turno = ve.Id_turno;
                this.Fecha_venta = ve.Fecha_venta;
                this.FechaVenta = this.Fecha_venta.ToString("yyyy-MM-dd");
                this.Hora_venta = ve.Hora_venta;
                this.Valor_venta = ve.Valor_venta;
                this.Interes_venta = ve.Interes_venta;
                this.Total_venta = ve.Total_venta;
                this.Numero_cuotas = ve.Numero_cuotas;
                this.Frecuencia_cobro = ve.Frecuencia_cobro;
                this.Valor_cuota = ve.Valor_cuota;
                this.Estado_venta = ve.Estado_venta;
                this.Tipo_venta = ve.Tipo_venta;

                this.Cliente = usuario;
                this.Direccion = direccion;
                this.Cobro = cobro;
                this.Tipo_producto = tipo;
                this.Turno = turno;
            }
            catch (Exception)
            {

            }
        }
        #endregion

        public int Id_venta { get; set; }
        public int Id_cobro { get; set; }
        public Cobros Cobro { get; set; }
        public int Id_tipo_producto { get; set; }
        public Tipo_productos Tipo_producto { get; set; }
        public int Id_cliente { get; set; }
        public Usuarios Cliente { get; set; }
        public int Id_direccion { get; set; }
        public Direccion_clientes Direccion { get; set; }
        public int Id_turno { get; set; }
        public Turnos Turno { get; set; }
        public DateTime Fecha_venta { get; set; }
        public string FechaVenta { get; set; }
        public TimeSpan Hora_venta { get; set; }
        public decimal Valor_venta { get; set; }
        public decimal Interes_venta { get; set; }
        public decimal Total_venta { get; set; }
        public int Numero_cuotas { get; set; }
        public string Frecuencia_cobro { get; set; }
        public decimal Valor_cuota { get; set; }
        public string Estado_venta { get; set; }
        public string Tipo_venta { get; set; }
    }
}
