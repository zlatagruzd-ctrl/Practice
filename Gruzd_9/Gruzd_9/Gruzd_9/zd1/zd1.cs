using System;
using System.IO;

namespace Gruzd_9
{
    public class zd1
    {
        public static void zd()
        {
            FileManager fm = new FileManager();
            FileInfoProvider fp = new FileInfoProvider();

            string dir = Directory.GetCurrentDirectory();
            string file = Path.Combine(dir, "gruzd.ze");
            string copy = Path.Combine(dir, "gruzd_copy.ze");
            string moved = Path.Combine(dir, "moved_gruzd.ze");

            Console.WriteLine("1. Создание файла и запись текста");
            fm.CreateFile(file, "Привет, это тестовый файл!");
            Console.WriteLine(File.ReadAllText(file));

            Console.WriteLine("\n2. Проверка существования перед удалением");
            if (File.Exists("нет_файла.txt"))
                fm.DeleteFile("нет_файла.txt");
            else
                Console.WriteLine("Файл не существует — удалять нечего");

            Console.WriteLine("\n3. Информация о файле");
            fp.PrintInfo(file);

            Console.WriteLine("\n4. Копирование файла");
            fm.CopyFile(file, copy);
            Console.WriteLine(File.Exists(copy) ? "Копия создана" : "Ошибка копирования");

            Console.WriteLine("\n5. Перемещение файла");
            fm.MoveFile(copy, moved);
            Console.WriteLine(File.Exists(moved) ? "Файл перемещён" : "Ошибка перемещения");

            Console.WriteLine("\n6. Переименование файла в familiya.io");
            fm.RenameFile(moved, "gruzd.io");
            string renamed = Path.Combine(dir, "gruzd.io");
            Console.WriteLine(File.Exists(renamed) ? "Переименован" : "Ошибка");

            Console.WriteLine("\n7. Ошибка при удалении несуществующего файла");
            try
            {
                fm.DeleteFile("abc123.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.WriteLine("\n8. Сравнение файлов по размеру");
            fm.CreateFile("file1.txt", "12345");
            fm.CreateFile("file2.txt", "1234567");

            long size1 = new FileInfo("file1.txt").Length;
            long size2 = new FileInfo("file2.txt").Length;

            Console.WriteLine(size1 > size2 ? "file1 больше" : "file2 больше");

            Console.WriteLine("\n9. Удаление файлов по шаблону *.ze");
            fm.DeleteByPattern(dir, "*.ze");

            Console.WriteLine("\n10. Список всех файлов в директории");
            fm.ListFiles(dir);

            Console.WriteLine("\n11. Запретить запись и попытаться записать");
            FileInfo fi = new FileInfo("file1.txt");
            fi.IsReadOnly = true;

            try
            {
                File.WriteAllText("file1.txt", "новый текст");
            }
            catch
            {
                Console.WriteLine("Запись запрещена — ошибка поймана");
            }

            fi.IsReadOnly = false;

            Console.WriteLine("\n12. Проверка прав доступа");
            fp.CheckPermissions("file1.txt");
        }
    }
}
