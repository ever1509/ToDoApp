using FluentValidation;

namespace Application.ToDo.Commands.AddToDoCommand
{
    public class AddToDoCommandValidator:AbstractValidator<AddToDoCommand>
    {
        public AddToDoCommandValidator()
        {
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Title).MaximumLength(25);
            RuleFor(e => e.Priority).NotEmpty();
            RuleFor(e => e.Note).NotEmpty();
            RuleFor(e => e.Note).MaximumLength(100);
            RuleFor(e => e.Done).NotEmpty();

        }
    }
}