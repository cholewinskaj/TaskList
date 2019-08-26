using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nowe_zadanie
{
    class FileSaver
    {
        public void SaveFiles()
        {
            // zapis do pliku
            // string[] lines = { $"{_taskList}" };
            // if (!File.Exists(path))
            string path = @"C:\Users\hermiodek\Desktop\MojaLista.txt";
            ToDoApp toDoApp = new ToDoApp();
            List<Task> _taskList;
            _taskList = new List<Task>();

            string[] createText = new string[_taskList.Count];
            for (int a = 0; a < _taskList.Count; a++)
            {
                Task task = _taskList[a];

                createText[a] = $"{a + 1}. [{task.ShowCheck()}] {task.Description}";
            }
            File.WriteAllLines(path, createText, Encoding.UTF8);

            /* inny sposb
             StreamWriter sw = File.CreateText(path);
             sw.WriteLine(lines);
             sw.Close();  */
            Console.WriteLine("file");
            string readText = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(readText);
        }
    }
}