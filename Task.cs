using System.Runtime.InteropServices;

namespace To_Do_List
{
    public class Task
    {
        private int Id;
        private string Title;

        public Task(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public string GetTitle()
        {
            return Title;
        }
        
    }
}