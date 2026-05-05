using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsUniversidad.Validators
{
    internal class EstudianteValidator
    {
        public static string ValidarEstudiante(string id, string nombre, string telefono, List<Materia> materias)
        {
            if (string.IsNullOrWhiteSpace(id))
                return "El ID es obligatorio";

            if (id.Length > 10)
                return "El ID no puede tener más de 10 caracteres";

            if (string.IsNullOrWhiteSpace(nombre))
                return "El nombre es obligatorio";

            if (nombre.Length > 50)
                return "El nombre no puede tener más de 50 caracteres";

            if (string.IsNullOrWhiteSpace(telefono))
                return "El teléfono es obligatorio";

            if (!telefono.All(char.IsDigit))
                return "El teléfono solo puede contener números";

            if (telefono.Length < 7 || telefono.Length > 10)
                return "El teléfono debe tener entre 7 y 10 dígitos";

            if (materias == null || materias.Count == 0)
                return "Seleccione al menos una materia";

            return string.Empty; 
        }
    }
}
