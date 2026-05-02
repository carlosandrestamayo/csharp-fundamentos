using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Data;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Controllers
{
    internal class ProfesorController
    {
        private ProfesorRepositorio profesorRepositorio;

        public ProfesorController()
        {
            profesorRepositorio = new ProfesorRepositorio();
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
