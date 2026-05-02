using System;
using System.Collections.Generic;
using System.Text;
using WinFormsUniversidad.Data;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Controllers
{
    internal class MateriaController
    {
        private MateriaRepositorio materiaRepositorio;

        public MateriaController()
        {
            materiaRepositorio = new MateriaRepositorio();
        }

        public List<Materia> ObtenerMaterias()
        {
            return materiaRepositorio.Leer();
        }

        public void AgregarMateria(Materia materia)
        {
            materiaRepositorio.Agregar(materia);
        }

        public void EditarMateria(string codigo, string nuevoNombre)
        {
            Materia materiaActualizada = new Materia(codigo, nuevoNombre);
            materiaRepositorio.Editar(materiaActualizada, codigo);
        }
    }
}
