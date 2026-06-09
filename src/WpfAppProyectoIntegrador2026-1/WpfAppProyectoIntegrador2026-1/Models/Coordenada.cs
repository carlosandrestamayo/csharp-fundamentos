using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class Coordenada
    {
        public decimal X { get; set; }

        public decimal Y { get; set; }

        public decimal Z { get; set; }

        [JsonIgnore]
        public string FormattedCoordinate
        {
            get
            {
                return $"({X}, {Y}, {Z})";
            }
        }

        [JsonConstructor]
        public Coordenada(
            decimal x,
            decimal y,
            decimal z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Coordenada()
        {
        }
    }
}
