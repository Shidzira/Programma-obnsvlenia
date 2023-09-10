using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Путь к папке, которую нужно скопировать
        string sourceFolderPath = "D:\хуй назначения";

        // Путь к папке назначения для резервной копии
        string destinationFolderPath = "ПУТЬ_К_ПАПКЕ_НА_ВНЕШНЕМ_ДИСКЕ";

        try
        {
            // Создание папки назначения для резервной копии (если она не существует)
            Directory.CreateDirectory(destinationFolderPath);

            // Копирование файлов из исходной папки в папку назначения
            DirectoryInfo sourceDirectory = new DirectoryInfo(sourceFolderPath);
            foreach (FileInfo file in sourceDirectory.GetFiles())
            {
                string destinationFilePath = Path.Combine(destinationFolderPath, file.Name);
                file.CopyTo(destinationFilePath, true);
            }

            Console.WriteLine("Резервная копия успешно создана.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при создании резервной копии: {ex.Message}");
        }
    }
}