using System;
using System.Collections.Generic;
using System.Text.Json;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Data
{
    internal class EstudianteRepositorio
    {
        public static readonly string filePath = "estudiante.json";

        public List<Estudiante> Leer()
        {
            List<Estudiante> lista = new List<Estudiante>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Estudiante>>(json) ?? lista;
                    }
                }
            }
            else
            {
                File.Create(filePath).Close();
            }

            return lista;
        }

        private void Guardar(List<Estudiante> lista)
        {
            var opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize(lista, opciones);
                sw.Write(json);
            }
        }

        public void Agregar(Estudiante estudiante)
        {
            List<Estudiante> lista = Leer();
            lista.Add(estudiante);
            Guardar(lista);
        }

        public void Editar(Estudiante nuevoEstudiante, string id)
        {
            List<Estudiante> lista = Leer();

            int index = lista.FindIndex(e => e.id == id);

            if (index != -1)
            {
                lista[index] = nuevoEstudiante;
                Guardar(lista);
            }
        }
    }
}