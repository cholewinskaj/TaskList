using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Nowe_zadanie
{
    class Program
    {
        public static void Main(string[] args)
        {
            ToDoApp toDoApp = new ToDoApp(); // 11,08,19 wywyolanie menu 

                Console.Title = " Start Menu ";

                bool shouldContinue = true;

                while (shouldContinue)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Add new task");
                    Console.WriteLine("2. Remove task");
                    Console.WriteLine("3. Show the list");
                    Console.WriteLine("4. Change the task");
                    Console.WriteLine("5. Finish");

                    ConsoleKeyInfo key = Console.ReadKey();
                    Console.Clear();
                    switch (key.Key)
                    {
                        case ConsoleKey.D1:
                            toDoApp.CreateNewTask();
                            break;
                        case ConsoleKey.D2:
                            toDoApp.RemoveTasks();
                            break;
                        case ConsoleKey.D3:
                            toDoApp.PrintTasks();
                            break;
                        case ConsoleKey.D4:
                            toDoApp.ChangeTask();
                            break;
                        case ConsoleKey.Escape:
                        case ConsoleKey.D5:
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
        static void AdTasksLoop(ToDoApp toDoApp)
        {
            string cont = "y";
            while (cont == "y")
            {
                toDoApp.CreateNewTask();
                Console.WriteLine("Do you want to continue? n/y");
                cont = Console.ReadLine();
            }
        }
        static void AddSampleTasks(ToDoApp toDoApp)
        {
            toDoApp.CreateNewTask("kawa");
            toDoApp.CreateNewTask("woda");
            toDoApp.CreateNewTask("kapcie");
        }
    }
}