using System;
using System.Collections.Generic;
using System.Text;
using WpfAppProyectoIntegrador2026_1.Models;

namespace WpfAppProyectoIntegrador2026_1.Validators
{
    public class MaterialValidator
    {
        public static string Validate(Material material)
        {
            // =========================================
            // NAME
            // =========================================

            if (string.IsNullOrWhiteSpace(material.Nombre))
            {
                return "Name is required.";
            }

            if (material.Nombre.Length < 3)
            {
                return "Name must contain at least 3 characters.";
            }

            if (material.Nombre.Length > 100)
            {
                return "Name cannot exceed 100 characters.";
            }

            // =========================================
            // UNIT PRICE
            // =========================================

            if (material.PrecioUnidad <= 0)
            {
                return "Unit price must be greater than 0.";
            }

            if (material.PrecioUnidad > 100000000)
            {
                return "Unit price is too large.";
            }

            // =========================================
            // DESCRIPTION
            // =========================================

            if (!string.IsNullOrWhiteSpace(material.Descripcion))
            {
                if (material.Descripcion.Length > 500)
                {
                    return "Description cannot exceed 500 characters.";
                }
            }

            // =========================================
            // VALID
            // =========================================

            return "";
        }
    }
}
