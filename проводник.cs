using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace хз
{
    internal class проводник
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консольный проводник файловой системы");
            Console.WriteLine("------------------------------------");

            while (true)
            {
                Console.WriteLine($"\nТекущая директория: {currentDirectory}");
                Console.WriteLine("\nВыберите действие:");
                Console.WriteLine("1. Просмотр содержимого каталога");
                Console.WriteLine("2. Перейти в подкаталог");
                Console.WriteLine("3. Вернуться в родительский каталог");
                Console.WriteLine("4. Просмотреть содержимое файла");
                Console.WriteLine("5. Создать каталог");
                Console.WriteLine("6. Создать файл");
                Console.WriteLine("7. Удалить файл или каталог");
                Console.WriteLine("8. Просмотр информации о дисках");
                Console.WriteLine("9. Выход");

                Console.Write("\nВведите номер команды: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ShowDirectoryContents();
                        break;
                    case "2":
                        EnterSubdirectory();
                        break;
                    case "3":
                        GoToParentDirectory();
                        break;
                    case "4":
                        ViewFileContents();
                        break;
                    case "5":
                        CreateDirectory();
                        break;
                    case "6":
                        CreateFile();
                        break;
                    case "7":
                        DeleteItem();
                        break;
                    case "8":
                        ShowDriveInfo();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Неверная команда!");
                        break;
                }
            }
        }

        static void ShowDirectoryContents()
        {
            try
            {
                Console.WriteLine("\nСодержимое каталога:");
                Console.WriteLine("---------------------");

                var directories = Directory.GetDirectories(currentDirectory);
                var files = Directory.GetFiles(currentDirectory);

                Console.WriteLine("\nКаталоги:");
                foreach (var dir in directories)
                {
                    Console.WriteLine($"  [DIR] {Path.GetFileName(dir)}");
                }

                Console.WriteLine("\nФайлы:");
                foreach (var file in files)
                {
                    Console.WriteLine($"  [FILE] {Path.GetFileName(file)}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void EnterSubdirectory()
        {
            Console.Write("\nВведите имя подкаталога: ");
            string subDir = Console.ReadLine();

            string newPath = Path.Combine(currentDirectory, subDir);

            if (Directory.Exists(newPath))
            {
                currentDirectory = newPath;
                Console.WriteLine($"Перешли в каталог: {currentDirectory}");
            }
            else
            {
                Console.WriteLine("Каталог не существует!");
            }
        }

        static void GoToParentDirectory()
        {
            DirectoryInfo parentDir = Directory.GetParent(currentDirectory);

            if (parentDir != null)
            {
                currentDirectory = parentDir.FullName;
                Console.WriteLine($"Перешли в каталог: {currentDirectory}");
            }
            else
            {
                Console.WriteLine("Вы в корневом каталоге!");
            }
        }

        static void ViewFileContents()
        {
            Console.Write("\nВведите имя файла для просмотра: ");
            string fileName = Console.ReadLine();

            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                try
                {
                    Console.WriteLine($"\nСодержимое файла {fileName}:");
                    Console.WriteLine("---------------------------");
                    string content = File.ReadAllText(filePath);
                    Console.WriteLine(content);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка чтения файла: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Файл не существует!");
            }
        }

        static void CreateDirectory()
        {
            Console.Write("\nВведите имя нового каталога: ");
            string dirName = Console.ReadLine();

            string newDirPath = Path.Combine(currentDirectory, dirName);

            try
            {
                Directory.CreateDirectory(newDirPath);
                Console.WriteLine($"Каталог '{dirName}' успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания каталога: {ex.Message}");
            }
        }

        static void CreateFile()
        {
            Console.Write("\nВведите имя нового файла: ");
            string fileName = Console.ReadLine();

            string filePath = Path.Combine(currentDirectory, fileName);

            if (File.Exists(filePath))
            {
                Console.WriteLine("Файл уже существует!");
                return;
            }

            Console.WriteLine("Введите содержимое файла (для завершения введите пустую строку):");
            string content = "";
            string line;

            while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
            {
                content += line + Environment.NewLine;
            }

            try
            {
                File.WriteAllText(filePath, content);
                Console.WriteLine($"Файл '{fileName}' успешно создан!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка создания файла: {ex.Message}");
            }
        }

        static void DeleteItem()
        {
            Console.Write("\nВведите имя файла или каталога для удаления: ");
            string itemName = Console.ReadLine();

            string itemPath = Path.Combine(currentDirectory, itemName);

            if (File.Exists(itemPath))
            {
                Console.Write($"Вы уверены, что хотите удалить файл '{itemName}'? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    try
                    {
                        File.Delete(itemPath);
                        Console.WriteLine("Файл успешно удален!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка удаления файла: {ex.Message}");
                    }
                }
            }
            else if (Directory.Exists(itemPath))
            {
                Console.Write($"Вы уверены, что хотите удалить каталог '{itemName}'? (y/n): ");
                if (Console.ReadLine().ToLower() == "y")
                {
                    try
                    {
                        Directory.Delete(itemPath, true);
                        Console.WriteLine("Каталог успешно удален!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ошибка удаления каталога: {ex.Message}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Файл или каталог не существует!");
            }
        }

        static void ShowDriveInfo()
        {
            Console.WriteLine("\nИнформация о дисках:");
            Console.WriteLine("--------------------");

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"\nДиск: {drive.Name}");
                Console.WriteLine($"  Тип: {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"  Файловая система: {drive.DriveFormat}");
                    Console.WriteLine($"  Общий объем: {drive.TotalSize / (1024 * 1024 * 1024)} GB");
                    Console.WriteLine($"  Свободно: {drive.TotalFreeSpace / (1024 * 1024 * 1024)} GB");
                }
            }
        }
    }
}
