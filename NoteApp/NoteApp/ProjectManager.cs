using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// Класс менеджера проекта
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Путь к файлу.
        /// </summary>
        private static string _defaultPath = Environment.GetFolderPath
        (Environment.SpecialFolder.ApplicationData) + @"\NoteApp\Note.notes";

        /// <summary>
        /// Свойство для пути к файлу.
        /// </summary>
        public static string DefaultPath
        {
            get => _defaultPath;
        }

        /// <summary>
        /// Метод сериализации данных.
        /// </summary>
        /// <param name="project">Данные для сериализации.</param>
        /// <param name="filepath">Путь до файла</param>
        public static void SaveToFile(Project project, string filePath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(filePath));
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(filePath))
            using (var writer = new JsonTextWriter(sw))
            {
                //Вызываем сериализацию и передаем объект, который хотим сериализовать.
                serializer.Serialize(writer, project);
            }
        }

        /// <summary>
        /// Метод десериализации данных.
        /// </summary>
        public static Project LoadFromFile(string filepath)
        {
            Project project;
            JsonSerializer serializer = new JsonSerializer();
            try
            {
                using (StreamReader sr = new StreamReader(filepath))
                using (JsonReader reader = new JsonTextReader(sr))
                    project = serializer.Deserialize<Project>(reader);
            }
            catch
            {
                return new Project();
            }
            return project;
        }
    }
}
