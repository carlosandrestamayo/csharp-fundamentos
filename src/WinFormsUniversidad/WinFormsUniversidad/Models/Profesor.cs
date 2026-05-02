using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsUniversidad.Models
{
    internal class Profesor : Persona
    {
        public Materia materia { get; set; }

        public Profesor() : base("", "", "")
        {
            this.materia = new Materia();
        }
        public Profesor(string id, string nombre, string telefono, Materia materia) : base(id, nombre, telefono)
        {
            this.materia = materia;
        }
    }
}
