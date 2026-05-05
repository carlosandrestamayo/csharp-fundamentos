using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Validators
{
    internal class MateriaValidator
    {
        public static string Validar(Materia materia)
        {
            if (materia == null)
                return "La materia no puede ser nula";

            if (string.IsNullOrWhiteSpace(materia.codigo))
                return "El código es obligatorio";

            if (materia.codigo.Length > 10)
                return "El código no puede tener más de 10 caracteres";

            if (string.IsNullOrWhiteSpace(materia.nombre))
                return "El nombre es obligatorio";

            if (materia.nombre.Length > 50)
                return "El nombre no puede tener más de 50 caracteres";

            return string.Empty; // null = válido
        }
    }
}
