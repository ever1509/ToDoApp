using FluentValidation;

namespace Application.ToDo.Commands.DeleteToDoCommand
{
    public class DeleteToDoCommandValidator:AbstractValidator<DeleteToDoCommand>
    {
        public DeleteToDoCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}