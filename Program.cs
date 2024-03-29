﻿using System;

namespace Nowe_zadanie
{
    class Program
    {
        static ToDoApp toDoApp;
        public static void Main(string[] args)
        {
            toDoApp = new ToDoApp(); // 11,08,19 wywyolanie menu 
            FileSaver fileSaver = new FileSaver();
            Console.Title = " Start Menu ";

            bool shouldContinue = true;

            while (shouldContinue)
            {
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Add new task");
                Console.WriteLine("2. Remove task");
                Console.WriteLine("3. Show the list");
                Console.WriteLine("4. Change the task");
                Console.WriteLine("5. Save to file ");
                Console.WriteLine("6. Read from file ");
                Console.WriteLine("7. Finish");

                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("Enter description for new task");
                        string taskDescription = Console.ReadLine();
                        toDoApp.CreateNewTask(taskDescription);
                        break;
                    case ConsoleKey.D2:
                        PrintTasks();
                        Console.WriteLine("which element should be removed?");
                        int index1 = Int32.Parse(Console.ReadLine());
                        try
                        {
                            toDoApp.RemoveTasks(index1);
                        }
                        catch (IndexOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine($"{index1} is out of the list range");
                        }
                        break;
                    case ConsoleKey.D3:
                        PrintTasks();
                        break;
                    case ConsoleKey.D4:
                        PrintTasks();
                        Console.WriteLine("Which task do you want to change?");
                        int index = Int32.Parse(Console.ReadLine());
                        try
                        {
                            toDoApp.ChangeTask(index);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.WriteLine($"{index} is out of the list range");
                        }
                        break;
                    case ConsoleKey.D5:
                        string[] table1 = toDoApp.PrintTasks();
                        fileSaver.SaveFiles(table1);
                        break;
                    case ConsoleKey.D6:
                        string[] readedLines = fileSaver.ReadFile();
                       
                        for (int i = 0; i < readedLines.Length; i++)
                        {
                            toDoApp.AddTaskFromLine(readedLines[i]);
                        }
                        
                        break;
                    case ConsoleKey.Escape:
                    case ConsoleKey.D7:
                        shouldContinue = false;
                        break; // niewiem czy to musi byc Environment.Exit(0)
                    default: break;
                }
            }
            // AdTasksLoop(toDoApp);

            /* AddSampleTasks(toDoApp);

            toDoApp.PrintTasks();
            toDoApp.RemoveTasks();
            toDoApp.PrintTasks();
            Console.ReadLine();

            Console.Clear();
            Console.ReadKey(); */
        }
        static void PrintTasks()
        {
            string[] table = toDoApp.PrintTasks();
            ConsolePrinter consolePrinter = new ConsolePrinter();
            consolePrinter.PrintTasks(table);
        }


        static void Temp()
        {
            for (int i= 9; i>0; i=i-2)
            {
Console.WriteLine(i);
            }


                    }
    }
}