using System;
using System.Collections.Generic;
using System.Text;

namespace WpfAppProyectoIntegrador2026_1.Models
{
    public class CotizacionDetalle
    {
        public Guid Id { get; set; }

        public Material Material { get; set; }

        // Cantidad de material (m³)
        public decimal Cantidad { get; set; }

        // Subtotal calculado
        public decimal Subtotal { get; set; }

        public CotizacionDetalle()
        {
            Material = new Material(new Guid(), "", 0,"");
        }

        public CotizacionDetalle(
            Guid id,
            Material material,
            decimal cantidad
        )
        {
            Id = id;

            Material = material;

            Cantidad = cantidad;

            Subtotal =
                cantidad * material.PrecioUnidad;
        }
    }
}
