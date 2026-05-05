using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WinFormsUniversidad.Models
{
    internal class Persona
    {
        public string id { get; set;}
        public string nombre { get; set; }
        public string telefono { get; set; }

        [JsonConstructor]
        public Persona(string id, string nombre, string telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.telefono = telefono;
        }
    }
}
