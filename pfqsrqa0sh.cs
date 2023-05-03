using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path_to_script = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        string path_to_000_txt = System.IO.Path.Combine(path_to_script, "000.txt");
    }
}
