using FluentValidation;

namespace Application.ToDo.Commands.UpdateToDoCommand
{
    public class UpdateToDoCommandValidator:AbstractValidator<UpdateToDoCommand>
    {
        public UpdateToDoCommandValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
            RuleFor(e => e.Title).NotEmpty();
            RuleFor(e => e.Title).MaximumLength(25);
            RuleFor(e => e.Priority).NotEmpty();
            RuleFor(e => e.Note).NotEmpty();
            RuleFor(e => e.Note).MaximumLength(100);
            RuleFor(e => e.Done).NotEmpty();
        }
    }
}