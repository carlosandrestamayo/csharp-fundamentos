using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;
using WinFormsUniversidad.Repositorys;

namespace WinFormsUniversidad.Controllers
{
    internal class EstudianteController
    {
        private EstudianteRepository estudianteRepository;

        public EstudianteController()
        {
            estudianteRepository = new EstudianteRepository();
        }

        public List<Estudiante> ObtenerEstudiantes()
        {
            return estudianteRepository.Leer();
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            estudianteRepository.Agregar(estudiante);
        }

        public void EditarEstudiante(string id, string nombre, string telefono, List<Materia> listaMaterias)
        {
            Estudiante estudianteActualizado = new Estudiante(id, nombre, telefono, listaMaterias);
            estudianteRepository.Editar(estudianteActualizado, id);
        }

    }
}
