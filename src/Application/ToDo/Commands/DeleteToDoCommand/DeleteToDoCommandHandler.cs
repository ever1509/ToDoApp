using System;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using MediatR;

namespace Application.ToDo.Commands.DeleteToDoCommand
{
    public class DeleteToDoCommandHandler:IRequestHandler<DeleteToDoCommand>
    {
        private readonly IDbContext _context;

        public DeleteToDoCommandHandler(IDbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteToDoCommand request, CancellationToken cancellationToken)
        {
            var entity = _context.ToDoItems.Find(request.Id);
            
            if(entity==null)
                throw new Exception();

            _context.ToDoItems.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}