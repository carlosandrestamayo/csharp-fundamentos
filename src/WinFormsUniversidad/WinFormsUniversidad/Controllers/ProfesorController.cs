using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Models;
using WinFormsUniversidad.Repositorys;

namespace WinFormsUniversidad.Controllers
{
    internal class ProfesorController
    {
        private ProfesorRepository profesorRepositorio;

        public ProfesorController()
        {
            profesorRepositorio = new ProfesorRepository();
        }

        public List<Profesor> ObtenerProfesores()
        {
            return profesorRepositorio.Leer();
        }

        public void AgregarProfesor(Profesor profesor)
        {
           profesorRepositorio.Agregar(profesor);
        }

        public void EditarProfesor(string id, string nombre, string telefono, Materia materia)
        {
            Profesor profesorActualizado = new Profesor(id, nombre, telefono, materia);
            profesorRepositorio.Editar(profesorActualizado, id);
        }
    }
}
