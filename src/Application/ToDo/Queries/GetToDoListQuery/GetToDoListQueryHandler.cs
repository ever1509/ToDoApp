using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.ToDo.Queries.GetToDoListQuery
{
    public class GetToDoListQueryHandler:IRequestHandler<GetToDoListQuery,ToDoListVm>
    {
        private readonly IDbContext _context;
        private readonly IMapper _mapper;
        public GetToDoListQueryHandler(IDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<ToDoListVm> Handle(GetToDoListQuery request, CancellationToken cancellationToken)
        {
            var priorityLevels = Enum.GetValues(typeof(PriorityLevel))
                .Cast<PriorityLevel>()
                .Select(p => new PriorityLevelDto() {Name = p.ToString(), Value = (int) p}).ToList();
            
            var toDoList = await _context.ToDoItems.Where(t => t.PriorityLevel == request.Priority)
                .ProjectTo<ToDoDto>(_mapper.ConfigurationProvider)
                .OrderBy(t=>t.Title)
                .ToListAsync(cancellationToken);
            
            return new ToDoListVm()
            {
                ToDoList = toDoList,
                PriorityLevels = priorityLevels
            };
        }
    }
}