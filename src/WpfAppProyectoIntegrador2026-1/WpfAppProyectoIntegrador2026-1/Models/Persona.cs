using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public abstract class Persona
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public string Identificacion { get; set; } = string.Empty;

        public string Telefono { get; set; } = string.Empty;

        public string Correo { get; set; } = string.Empty;

        [JsonConstructor]
        public Persona(Guid id, string nombre, string identificacion, string telefono, string correo)
        {
            Id = id;
            Nombre = nombre;
            Identificacion = identificacion;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
