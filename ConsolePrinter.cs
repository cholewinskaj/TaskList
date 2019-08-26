using System;

namespace Nowe_zadanie
{
    class ConsolePrinter
    {
        public void PrintTasks(string[] table)
        {
            Console.WriteLine("Tasks of the list are:");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine(table[i]);
            }
        }
    }
}