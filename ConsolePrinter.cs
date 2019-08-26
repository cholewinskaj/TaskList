using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nowe_zadanie
{
    class ConsolePrinter
    {
        public void Printer()
        {
            FileSaver fileSaver = new FileSaver();
        
            string path = @"C:\Users\hermiodek\Desktop\MojaLista.txt";
            
            string readText = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(readText);
        }
    }
}