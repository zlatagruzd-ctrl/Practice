using System;
using System.IO;

namespace Gruzd_9
{
    public class FileManager
    {
        public void CreateFile(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public void DeleteFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            else
                throw new FileNotFoundException("Файл не найден.");
        }

        public void CopyFile(string source, string destination)
        {
            File.Copy(source, destination, true);
        }

        public void MoveFile(string source, string destination)
        {
            File.Move(source, destination);
        }

        public void RenameFile(string path, string newName)
        {
            string directory = Path.GetDirectoryName(path);
            string newPath = Path.Combine(directory, newName);
            File.Move(path, newPath);
        }

        public void DeleteByPattern(string directory, string pattern)
        {
            string[] files = Directory.GetFiles(directory, pattern);
            foreach (var file in files)
                File.Delete(file);
        }

        public void ListFiles(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            foreach (var file in files)
                Console.WriteLine(file);
        }
    }
}