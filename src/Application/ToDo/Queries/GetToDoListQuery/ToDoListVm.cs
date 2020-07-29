using System.Collections.Generic;

namespace Application.ToDo.Queries.GetToDoListQuery
{
    public class ToDoListVm
    {
        public IList<ToDoDto> ToDoList { get; set; }
        public IList<PriorityLevelDto> PriorityLevels { get; set; }
    }
}