using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Data;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Controllers
{
    internal class EstudianteController
    {
        private EstudianteRepositorio estudianteRepositorio;

        public EstudianteController()
        {
            estudianteRepositorio = new EstudianteRepositorio();
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return estudianteRepositorio.Leer();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudianteRepositorio.Agregar(estudiante);
        }

        public void EditarEstudiante(string id, string nombre, string telefono, List<Materia> listaMaterias)
        {
            Estudiante estudianteActualizado = new Estudiante(id, nombre, telefono, listaMaterias);
            estudianteRepositorio.Editar(estudianteActualizado, id);
        }

    }
}
