using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class TerrainFile
    {
        public string Nombre { get; set; } = string.Empty;

        public string Descripcion { get; set; } = string.Empty;

        public List<Coordenada> Coordenadas { get; set; } = new();
    }
}
