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

        public override string ToString()
        {
            return string.Format("Id: {0}, Title: {1}, Type: {2}, Prior: {3}, Date: {4}, Multiplier: {5}", Id, Title, Type, Prior, Date, Multiplier);

        }
    }
}