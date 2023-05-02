using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] names_txt_work_files = {"Global", "Local", "Glo Concr", "Glo Hlam", "Bud"};

        using (StreamWriter writer = new StreamWriter("000.txt"))
        {
            foreach (string name in names_txt_work_files)
            {
                writer.WriteLine(name);
                writer.WriteLine("--------------------------------------------------");
            }
        }я

        Console.WriteLine("Готово!");
        Console.ReadLine();
    }
}
