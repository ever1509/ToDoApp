using System;
using Domain.Enums;
using MediatR;

namespace Application.ToDo.Commands.AddToDoCommand
{
    public class AddToDoCommand:IRequest
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public DateTime? Reminder { get; set; }
        public PriorityLevel Priority { get; set; }
        public bool Done { get; set; }
    }
}