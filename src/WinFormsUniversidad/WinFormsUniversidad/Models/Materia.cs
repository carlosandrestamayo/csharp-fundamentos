using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace WinFormsUniversidad.Models
{
    internal class Materia
    {

        public string filePath = "materia.json";
        private object txtCodio;

        public string codigo { get; set; }

        public string nombre { get; set; }

        public string getCodigo()
        {
            return this.codigo;
        }

        public string getNombre()
        {
            return this.nombre ;
        }

        public Materia()
        {

        }
        public Materia(string codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre;
        }

        public Materia(object txtCodio)
        {
            this.txtCodio = txtCodio;
        }
    }
}
