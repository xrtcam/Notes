using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory(); // путь к директории где скрипт выполняется.
        // Directory.SetCurrentDirectory(currentDirectory); // перейти в указанную директорию
        Console.WriteLine(currentDirectory); // D:\Path\to\xxx2
    }
}
