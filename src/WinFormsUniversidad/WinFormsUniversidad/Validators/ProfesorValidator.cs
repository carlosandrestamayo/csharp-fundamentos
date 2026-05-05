using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Validators
{
    internal class ProfesorValidator
    {
        public static string Validar(Profesor profesor)
        {
            if (profesor == null)
                return "El profesor no puede ser nulo";

            if (string.IsNullOrWhiteSpace(profesor.id))
                return "El ID es obligatorio";

            if (profesor.id.Length > 10)
                return "El ID no puede tener más de 10 caracteres";

            if (string.IsNullOrWhiteSpace(profesor.nombre))
                return "El nombre es obligatorio";

            if (profesor.nombre.Length > 50)
                return "El nombre no puede tener más de 50 caracteres";

            if (string.IsNullOrWhiteSpace(profesor.telefono))
                return "El teléfono es obligatorio";

            if (!profesor.telefono.All(char.IsDigit))
                return "El teléfono solo puede contener números";

            if (profesor.telefono.Length < 7 || profesor.telefono.Length > 10)
                return "El teléfono debe tener entre 7 y 10 dígitos";

            if (profesor.materia == null)
                return "Debe seleccionar una materia";

            return string.Empty; // null = válido
        }
    }
}
