using Application.Common.Mappings;
using AutoMapper;
using Domain.Entities;

namespace Application.ToDo.Queries.GetToDoListQuery
{
    public class ToDoDto:IMapFrom<ToDoDto>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Note { get; set; }
        public bool Done { get; set; }
        public int Priority { get; set; }
        
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ToDoItem, ToDoDto>()
                .ForMember(d => d.Priority, opt => opt.MapFrom(s => (int) s.PriorityLevel));
        }
    }
}