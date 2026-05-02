using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUniversidad.Models
{
    internal class Estudiante : Persona
    {
        public List<Materia> listaMaterias { get; set; }

        public Estudiante() : base("", "", "")
        { 
            this.listaMaterias = new List<Materia>();
        }

        public Estudiante(string id, string nombre, string telefono, List<Materia> listaMaterias): base(id, nombre, telefono)
        {
            this.listaMaterias = listaMaterias;
        }
    }
}
