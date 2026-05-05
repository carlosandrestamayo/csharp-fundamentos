using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WinFormsUniversidad.Models
{
    internal class Materia
    {
        public string codigo { get; set; }

        public string nombre { get; set; }

        [JsonConstructor]
        public Materia(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

    }
}
