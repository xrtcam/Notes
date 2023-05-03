using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string currentDirectory = Directory.GetCurrentDirectory();
        //
        string path = Path.Combine("C:", "Users", "User", "Documents", "MyFolder"); // путь к директории
        Directory.SetCurrentDirectory(path); // перейти в указанную директорию

        string myString = "Привет, мир!";
        Console.WriteLine(myString);
    }
}
