using System.Collections.Generic;

namespace To_Do_List
{
    public class TaskList
    {
        private List<Task> task = new List<Task>();

        public void AddTask(Task taskToAdd)
        {
            task.Add(taskToAdd);
        }

        public Task ReadTask(int Id)
        {
            return task[Id];
        }

        public int CountOfTaskList()
        {
            return task.Count;
        }

        public void RemoveTask(int taskToRemove)
        {
            task.RemoveAt(taskToRemove);
        }
    }
}