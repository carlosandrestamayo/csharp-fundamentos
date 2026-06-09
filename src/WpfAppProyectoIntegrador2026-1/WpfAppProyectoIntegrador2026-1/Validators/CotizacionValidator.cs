using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Validators
{
    class CotizacionValidator
    {
        public static string Validate(Cotizacion cotizacion)
        {
            if (cotizacion.Cliente == null)
            {
                return "Client is required.";
            }

            if (cotizacion.Numero <= 0)
            {
                return "Invalid quotation number.";
            }

            //if (cotizacion.Volumen <= 0)
            //{
            //    return "Volume must be greater than zero.";
            //}

            if (cotizacion.Detalles == null || !cotizacion.Detalles.Any())

            {
                return "The quotation must contain at least one item.";
            }

            if (cotizacion.Total <= 0)
            {
                return "Total amount must be greater than zero.";
            }

            return string.Empty;
        }
    }
}
