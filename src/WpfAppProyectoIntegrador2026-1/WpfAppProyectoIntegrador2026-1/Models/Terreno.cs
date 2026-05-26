using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Terreno
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        // Coordenadas o descripción
        public string Coordenadas { get; set; }

        public Terreno(Guid id, string nombre, string coordenadas)
        {
            Id = id;
            Nombre = nombre;
            Coordenadas = coordenadas;
        }
    }
}
