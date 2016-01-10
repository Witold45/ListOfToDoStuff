using System;
using System.Runtime.InteropServices;
using System.Windows.Data;

namespace To_Do_List
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public TypeOfTask Type { get; set; }
        public int Prior { get; set; }
        public DateTime Date { get; set; }
        public decimal Multiplier { get; set; }
        public Task(int id, string title, TypeOfTask type,int prior, DateTime date, decimal multiplier)
        {
            Id = id;
            Title = title;
            Type = type;
            Prior = prior;
            Date = date;
            Multiplier = multiplier;

        }

        public string GetTitle()
        {
            return Title;
        }
        
    }
}