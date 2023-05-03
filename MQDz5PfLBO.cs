using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = Path.Combine("C:", "Users", "User", "Documents", "MyFolder"); // путь к директории
        Directory.SetCurrentDirectory(path); // перейти в указанную директорию
    }
}

// Для того, чтобы перейти в директорию на C# можно использовать классы `System.IO.Directory` и `System.IO.Path`.
// В этом примере мы сначала объединяем имя диска и названия всех подпапок, которые нужно пройти, используя метод `Path.Combine()`. Затем используем метод `Directory.SetCurrentDirectory()`, чтобы установить текущую рабочую директорию.
