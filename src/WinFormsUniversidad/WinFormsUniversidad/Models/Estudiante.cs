using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WinFormsUniversidad.Models
{
    internal class Estudiante : Persona
    {
        public List<Materia> listaMaterias { get; set; }

        [JsonConstructor]
        public Estudiante(string id, string nombre, string telefono, List<Materia> listaMaterias): base(id, nombre, telefono)
        {
            this.listaMaterias = listaMaterias;
        }
    }
}
