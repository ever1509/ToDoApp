using MediatR;

namespace Application.ToDo.Commands.DeleteToDoCommand
{
    public class DeleteToDoCommand:IRequest
    {
        public int Id { get; set; }
    }
}