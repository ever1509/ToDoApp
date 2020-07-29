using System;
using Domain.Enums;

namespace Domain.Entities
{
    public class ToDoItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool Done { get; set; }
        public DateTime? Reminder { get; set; }
        public PriorityLevel PriorityLevel { get; set; }
    }
}