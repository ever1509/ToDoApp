using System;
using Domain.Enums;
using MediatR;

namespace Application.ToDo.Queries.GetToDoListQuery
{
    public class GetToDoListQuery:IRequest<ToDoListVm>
    {
        public PriorityLevel Priority { get; set; }
        public DateTime? Reminder { get; set; }
    }
}