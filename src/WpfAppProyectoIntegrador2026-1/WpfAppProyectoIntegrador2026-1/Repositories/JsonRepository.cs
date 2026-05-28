using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace WpfAppProyectoIntegrador2026_1.Repositorys
{
    public class JsonRepository<T> where T : class
    {
        private readonly string filePath;
        private readonly string folder;

        public JsonRepository(string folder, string filePath)
        {
            this.folder = folder;
            this.filePath = filePath;
        }

        // =====================================================
        // GET ALL
        // =====================================================

        public List<T> GetAll()
        {
            List<T> list = new List<T>();

            try
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string json =
                            sr.ReadToEnd();

                        if (json != string.Empty)
                        {
                            list = JsonSerializer.Deserialize<List<T>>(json) ?? list;
                        }
                    }
                }
                else
                {
                    Directory.CreateDirectory(folder);

                    File.WriteAllText(filePath, "[]");
                }

                return list;
            }
            catch (JsonException ex)
            {
                throw new Exception("El archivo JSON está corrupto.", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new Exception("No tienes permisos para acceder al archivo.", ex);
            }
            catch (IOException ex)
            {
                throw new Exception("Error de lectura o escritura del archivo.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado al cargar los datos.", ex);
            }
        }

        public List<T> Leer()
        {
            List<T> lista = new List<T>();

            if (File.Exists(filePath))
            {

                using (StreamReader sr = new StreamReader(filePath))
                {
                    string json = sr.ReadToEnd();

                    if (json != String.Empty)
                    {
                        lista = JsonSerializer.Deserialize<List<T>>(json) ?? lista;
                    }
                }

            }
            else
            {
                Directory.CreateDirectory(folder);
                File.WriteAllText(filePath, "[]");
            }

            return lista;
        }

        // =====================================================
        // SAVE
        // =====================================================

        public void Save(List<T> list)
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                    WriteIndented = true
            };

            using (StreamWriter sw =
                new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize(list, options);
                sw.Write(json);
            }
        }

        public void Guardar(List<T> lista)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                string json = JsonSerializer.Serialize<List<T>>(lista, opciones);
                sw.Write(json);
            }
        }

        // =====================================================
        // UPDATE
        // =====================================================

        public void Update(T newItem, Func<T, bool> predicate)
        {
            List<T> list = GetAll();

            int index = list.FindIndex(item => predicate(item));

            if (index != -1)
            {
                list[index] = newItem;

                Save(list);
            }
        }

        public void Editar(T nuevoItem, Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            int index = lista.FindIndex(item => criterio(item));
            if (index != -1)
            {
                lista[index] = nuevoItem;
                Guardar(lista);
            }
        }

        // =====================================================
        // DELETE
        // =====================================================

        public void Delete(Func<T, bool> predicate)
        {
            List<T> list = GetAll();

            list.RemoveAll(item => predicate(item));

            Save(list);
        }


        public void Eliminar(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            lista.RemoveAll(item => criterio(item));
            Guardar(lista);
        }

        // =====================================================
        // FIND
        // =====================================================

        public T? Find(Func<T, bool> predicate)
        {
            List<T> list = GetAll();

            return list.FirstOrDefault(item =>
                predicate(item));
        }

        public T? Buscar(Func<T, bool> criterio)
        {
            List<T> lista = Leer();
            return lista.FirstOrDefault(item => criterio(item));
        }

    }
}

