﻿namespace SISTotalControl.Entidades.ModelosBindeo
{
    using Newtonsoft.Json;
    using SISTotalControl.Entidades.Modelos;
    using System.Collections.Generic;

    public class LoginDataModel
    {
        //TRABAJADOR
        [JsonProperty("Credenciales")]
        public Credenciales Credenciales { get; set; }
        [JsonProperty("Turno")]
        public Turnos Turno { get; set; }
        [JsonProperty("Usuarios_reglas")]
        public List<Usuarios_reglas> Usuarios_reglas { get; set; }
        [JsonProperty("Reglas")]
        public List<Reglas> Reglas { get; set; }
        [JsonProperty("Agendamientos_cobros")]
        public List<Agendamiento_cobros> Agendamientos_cobros { get; set; }
        [JsonProperty("Tipo_productos")]
        public List<Tipo_productos> Tipo_productos { get; set; }
        public Cobros CobroDefault { get; set; }
        public Tipo_productos TipoProductoDefault { get; set; }
        public Zonas ZonaDefault { get; set; }
        public Ciudades CiudadDefault { get; set; }
        public Paises PaisDefault { get; set; }

        //ADMINISTRADOR
        [JsonProperty("Solicitudes")]
        public List<Solicitudes> Solicitudes { get; set; }
        [JsonProperty("Cobros")]
        public List<Cobros> Cobros { get; set; }

        public string Tipo_usuario { get; set; }
    }
}
