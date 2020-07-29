using System;
using Domain.Enums;
using MediatR;

namespace Application.ToDo.Commands.UpdateToDoCommand
{
    public class UpdateToDoCommand:IRequest<bool>
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public bool Done { get; set; }
        public PriorityLevel Priority { get; set; }
        public DateTime? Reminder { get; set; }
        public int Id { get; set; }
    }
}