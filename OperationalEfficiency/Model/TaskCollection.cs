using System.Collections;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components;

namespace OperationalEfficiency.Model
{
    public class TaskCollection
    {
        private ICollection<Task> _tasks;


        public TaskCollection()
        {
            _tasks = new List<Task>();
        }

        public ICollection<Task> GetAllTasks()
        {
            return _tasks;
        }

        public long Count()
        {
            return _tasks.Count();
        }

        public void Add(Task task)
        {
            _tasks.Add(task);
        }

        public void Clear()
        {
            _tasks.Clear();
        }

        public bool Remove(Task task)
        {
            return _tasks.Remove(task);
        }

        public void Delete(Task task)
        {
            task.Deleted = true;
        }
    }
}
