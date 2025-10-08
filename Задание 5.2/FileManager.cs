using System.IO;

namespace TextEditorApp
{
    public class FileManager
    {
        // Метод для открытия файла и чтения его содержимого
        public string OpenFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return string.Empty;
        }

        // Метод для сохранения данных в файл
        public void SaveFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
    }
}
