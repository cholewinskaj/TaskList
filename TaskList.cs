using System.Collections.Generic;

namespace Nowe_zadanie
{
    class TaskList
    {
        List<Task> Tasks;
        public void AddTask(Task task)
        {
            if (Tasks == null)
            {
                Tasks = new List<Task>();
            }
            Tasks.Add(task);
        }
    }
}