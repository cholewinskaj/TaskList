using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Nowe_zadanie
{
    class ToDoApp
    {
        public List<Task> _taskList;
        public void CreateNewTask()
        {
            Console.WriteLine("Enter description for new task");
            string taskDescription;
            taskDescription = Console.ReadLine();

            CreateNewTask(taskDescription);
        }
        public void CreateNewTask(string taskDescription)
        {
            if (_taskList == null)
            {
                _taskList = new List<Task>();
            }

            Task task = new Task();
            task.Description = taskDescription;
            _taskList.Add(task);
        }

        public void PrintTasks()
        {
            Console.WriteLine("Tasks of the list are:");
            for (int i = 0; i < _taskList.Count; i++) /* _taskList.Count sumuje ilosc obiektow na liscie */
            {
                Task task = _taskList[i];
                Console.WriteLine($"{i + 1}. [{task.ShowCheck()}] {task.Description}");
                FileSaver fileSaver = new FileSaver();
                fileSaver.SaveFiles();                
            }
        }

        public void RemoveTasks()
        {
            PrintTasks();
            Console.WriteLine("which element should be removed?");
            int index = Int32.Parse(Console.ReadLine());
            if (index <= _taskList.Count && index > 0)
            {
                _taskList.RemoveAt(index - 1);
            }
            else
            {
                Console.WriteLine($"The list is shorter then {index}");
            }
        }
        public void ChangeTask()
        {
            PrintTasks();
            Console.WriteLine("Which task do you want to change?");
            int index = Int32.Parse(Console.ReadLine());
            if (index <= _taskList.Count && index > 0)
            {
                Task taskForChange = _taskList[index - 1];

                taskForChange.Check = !taskForChange.Check;
            }
        }
    }
}