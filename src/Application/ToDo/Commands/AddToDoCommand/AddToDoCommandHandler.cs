using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;

namespace Application.ToDo.Commands.AddToDoCommand
{
    public class AddToDoCommandHandler:IRequestHandler<AddToDoCommand>
    {
        private readonly IDbContext _context;

        public AddToDoCommandHandler(IDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(Commands.AddToDoCommand.AddToDoCommand request, CancellationToken cancellationToken)
        {
            var entity = new ToDoItem()
            {
                Title = request.Title,
                Note = request.Note,
                Reminder = request.Reminder,
                Done = request.Done,
                PriorityLevel = request.Priority
            };

            _context.ToDoItems.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}