using System;
using System.IO;
using System.Text;

namespace Nowe_zadanie
{
    class FileSaver
    {
        public void SaveFiles(string[] table)
        {
            // zapis do pliku
            // string[] lines = { $"{_taskList}" };
            // if (!File.Exists(path))
            string path = @"C:\Users\hermiodek\Desktop\MojaLista.txt";
            File.WriteAllLines(path, table, Encoding.UTF8);

            /* inny sposb
             StreamWriter sw = File.CreateText(path);
             sw.WriteLine(lines);
             sw.Close();  */
            Console.WriteLine("file saved");
        }

        public string[] ReadFile()
        {
            string[] lines = File.ReadAllLines(@"C:\Users\hermiodek\Desktop\MojaLista.txt");
            return lines;
        }
    }
}