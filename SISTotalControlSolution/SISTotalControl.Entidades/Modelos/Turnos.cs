namespace SISTotalControl.Entidades.Modelos
{
    using SISTotalControl.Entidades.Helpers;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data;
    using System.Globalization;

    public class Turnos
    {
        public Turnos()
        {

        }

        public Turnos(DataRow row)
        {
            this.Id_turno = ConvertValueHelper.ConvertirNumero(row["Id_turno"]);
            this.Id_cobrador = ConvertValueHelper.ConvertirNumero(row["Id_cobrador"]);
            
            this.Id_cobro = ConvertValueHelper.ConvertirNumero(row["Id_cobro"]);
            
            this.Fecha_inicio_turno = ConvertValueHelper.ConvertirFecha(row["Fecha_inicio_turno"]);
            this.Fecha_fin_turno = ConvertValueHelper.ConvertirFecha(row["Fecha_fin_turno"]);
            this.Hora_inicio_turno = ConvertValueHelper.ConvertirHora(row["Hora_inicio_turno"]);
            this.Hora_fin_turno = ConvertValueHelper.ConvertirHora(row["Hora_fin_turno"]);
            this.Valor_inicial = ConvertValueHelper.ConvertirDecimal(row["Valor_inicial"]);
            this.Clientes_iniciales = ConvertValueHelper.ConvertirNumero(row["Clientes_iniciales"]);
            this.Clientes_nuevos = ConvertValueHelper.ConvertirNumero(row["Clientes_nuevos"]);
            this.Clientes_cancelados = ConvertValueHelper.ConvertirNumero(row["Clientes_cancelados"]);
            this.Clientes_total = ConvertValueHelper.ConvertirNumero(row["Clientes_total"]);
            this.Recaudo_ventas_nuevas = ConvertValueHelper.ConvertirDecimal(row["Recaudo_ventas_nuevas"]);
            this.Recaudo_cuotas = ConvertValueHelper.ConvertirDecimal(row["Recaudo_cuotas"]);
            this.Recaudo_otros = ConvertValueHelper.ConvertirDecimal(row["Recaudo_otros"]);
            this.Recaudo_pretendido_turno = ConvertValueHelper.ConvertirDecimal(row["Recaudo_pretendido_turno"]);
            this.Recaudo_real = ConvertValueHelper.ConvertirDecimal(row["Recaudo_real"]);
            this.Gastos_total = ConvertValueHelper.ConvertirDecimal(row["Gastos_total"]);
            this.Estado_turno = ConvertValueHelper.ConvertirCadena(row["Estado_turno"]);

            this.Cobrador = new Usuarios(row);
            this.Cobro = new Cobros(row);
        }

        public Turnos(Turnos turno)
        {
            this.Id_turno = turno.Id_turno;
            this.Id_cobrador = turno.Id_cobrador;
            this.Cobrador = turno.Cobrador;
            this.Id_cobro = turno.Id_cobro;
            this.Cobro = turno.Cobro;
            this.Fecha_inicio_turno = turno.Fecha_inicio_turno;
            this.Fecha_fin_turno = turno.Fecha_fin_turno;
            this.Hora_inicio_turno = turno.Hora_inicio_turno;
            this.Hora_fin_turno = turno.Hora_fin_turno;
            this.Valor_inicial = turno.Valor_inicial;
            this.Clientes_iniciales = turno.Clientes_iniciales;
            this.Clientes_nuevos = turno.Clientes_nuevos;
            this.Clientes_cancelados = turno.Clientes_cancelados;
            this.Clientes_total = turno.Clientes_total;
            this.Recaudo_ventas_nuevas = turno.Recaudo_ventas_nuevas;
            this.Recaudo_cuotas = turno.Recaudo_cuotas;
            this.Recaudo_otros = turno.Recaudo_otros;
            this.Recaudo_pretendido_turno = turno.Recaudo_pretendido_turno;
            this.Recaudo_real = turno.Recaudo_real;
            this.Gastos_total = turno.Gastos_total;
            this.Estado_turno = turno.Estado_turno;
        }

        public int Id_turno { get; set; }
        public int Id_cobrador { get; set; }
        public virtual Usuarios Cobrador { get; set; }
        public int Id_cobro { get; set; }
        public virtual Cobros Cobro { get; set; }
        public DateTime Fecha_inicio_turno { get; set; }
        public DateTime Fecha_fin_turno { get; set; }
        public TimeSpan Hora_inicio_turno { get; set; }
        public TimeSpan Hora_fin_turno { get; set; }
        public decimal Valor_inicial { get; set; }
        public int Clientes_iniciales { get; set; }
        public int Clientes_nuevos { get; set; }
        public int Clientes_cancelados { get; set; }
        public int Clientes_total { get; set; }
        public decimal Recaudo_ventas_nuevas { get; set; }
        public decimal Recaudo_cuotas { get; set; }
        public decimal Recaudo_otros { get; set; }
        public decimal Recaudo_pretendido_turno { get; set; }
        public decimal Recaudo_real { get; set; }
        public decimal Gastos_total { get; set; }
        public string Estado_turno { get; set; }
        public List<Agendamiento_cobros> AgendamientosTurno { get; set; }

        public string PorcentajeClientesVisitados
        {
            get
            {
                if (this.Clientes_cancelados == 0) return "%0";
                decimal porcentaje = (this.Clientes_cancelados * 100) / this.Clientes_iniciales;
                return $"{porcentaje}%";
            }
        }
        public string PorcentajeRecaudado
        {
            get
            {
                if (this.Recaudo_cuotas == 0) return "%0";
                decimal porcentaje = (this.Recaudo_cuotas * 100) / this.Recaudo_pretendido_turno;
                return $"{porcentaje.ToString("N2").Replace("0.00", "")}%";
            }
        }
        public string SeEsperaRecaudar
        {
            get
            {
                return $"Se espera recaudar ${this.Recaudo_pretendido_turno.ToString("N2").Replace(".00", "")}";
            }
        }
        public string RecaudoActual
        {
            get
            {
                return $"Recaudo actual ${this.Recaudo_cuotas.ToString("N2").Replace(".00", "")}";
            }
        }
        public string FechaTurnoActual
        {
            get
            {
                CultureInfo colCulture = CultureInfo.CreateSpecificCulture("es-CO");
                DateTime colFormatDateTime = this.Fecha_inicio_turno;
                DateTime dateHora = colFormatDateTime.Add(this.Hora_inicio_turno);

                return $"{dateHora.ToString(colCulture.DateTimeFormat).ToUpperInvariant()}";
            }
        }
        public string CajaInicialActual
        {
            get
            {
                return $"Caja inicial ${this.Valor_inicial.ToString("N2").Replace(".00", "")}";
            }
        }
        public string ClientesNuevosActual
        {
            get
            {
                return $"Clientes nuevos {this.Clientes_nuevos} | (${this.Recaudo_ventas_nuevas.ToString("N2").Replace(".00", "")})";
            }
        }
        public string GastosActual
        {
            get
            {
                return $"Gastos ${this.Gastos_total.ToString("N2").Replace(".00", "")}";
            }
        }
        public string TotalTurnoActual
        {
            get
            {
                return $"Total caja ${this.Recaudo_real.ToString("N2").Replace(".00", "")}";
            }
        }
    }
}
