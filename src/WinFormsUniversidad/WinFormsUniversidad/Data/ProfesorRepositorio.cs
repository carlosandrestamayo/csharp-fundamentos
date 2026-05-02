using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using WinFormsUniversidad.Models;

namespace WinFormsUniversidad.Data
{
    internal class ProfesorRepositorio
    {
        public static readonly string filePath = "profesor.json";

        public List<Profesor> Leer()
        {
            List<Profesor> lista = new List<Profesor>();

            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (!string.IsNullOrWhiteSpace(json))
                    {
                        lista = JsonSerializer.Deserialize<List<Profesor>>(json) ?? lista;
                    }
                }
            }
            else
            {
                File.Create(filePath).Close();
            }

            return lista;
        }

        private void Guardar(List<Profesor> lista)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize(lista, opciones);
                sw.Write(json);
            }
        }

        public void Agregar(Profesor profesor)
        {
            List<Profesor> lista = this.Leer();
            lista.Add(profesor);
            this.Guardar(lista);
        }

        public void Editar(Profesor nuevoProfesor, string id)
        {
            List<Profesor> lista = Leer();

            int index = lista.FindIndex(p => p.id == id);

            if (index != -1)
            {
                lista[index] = nuevoProfesor;
                this.Guardar(lista);
            }
        }
    }
}