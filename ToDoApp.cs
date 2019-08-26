using System.Collections.Generic;
using System;

namespace Nowe_zadanie
{
    class ToDoApp
    {
        public List<Task> _taskList;
      
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

        public string[] PrintTasks()
        {            
            string[] table = new string[_taskList.Count];
            for (int i = 0; i < _taskList.Count; i++) /* _taskList.Count sumuje ilosc obiektow na liscie */
            {
                Task task = _taskList[i];
                table[i] = $"{i + 1}. [{task.ShowCheck()}] {task.Description}";                               
            }
            return table;
        }

        public void RemoveTasks(int index)
        {                        
            if (index <= _taskList.Count && index > 0)
            {
                _taskList.RemoveAt(index - 1);                
            }
            else
            {
                throw new IndexOutOfRangeException("DUpa");
            }
        }

        public void ChangeTask(int index)
        {            
            //if (index <= _taskList.Count && index > 0)
           // {
                Task taskForChange = _taskList[index - 1];
                taskForChange.Check = !taskForChange.Check;
           // }
        }
    }
}