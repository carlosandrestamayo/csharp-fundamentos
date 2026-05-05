using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WinFormsUniversidad.Models
{
    internal class Profesor : Persona
    {
        public Materia materia { get; set; }

        [JsonConstructor]
        public Profesor(string id, string nombre, string telefono, Materia materia) : base(id, nombre, telefono)
        {
            this.materia = materia;
        }
    }
}
