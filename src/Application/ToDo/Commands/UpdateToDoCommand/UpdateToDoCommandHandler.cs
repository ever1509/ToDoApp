using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.ToDo.Commands.UpdateToDoCommand
{
    public class UpdateToDoCommandHandler:IRequestHandler<UpdateToDoCommand,bool>
    {
        private readonly IDbContext _context;

        public UpdateToDoCommandHandler(IDbContext context)
        {
            _context = context;
        }
        public async Task<bool> Handle(UpdateToDoCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.ToDoItems.Find(request.Id);
            
            if(entity==null)
                throw new Exception($"entity doesnt find with the id {request.Id}");

            entity.Done = request.Done;
            entity.Note = request.Note;
            entity.Reminder = request.Reminder;
            entity.Title = request.Title;
            entity.PriorityLevel = request.Priority;

            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}