using FluentValidation;

namespace TauCode.Testing.Tests.Core.Features.SystemWatchers.DeleteSystemWatcher
{
    public class DeleteSystemWatcherCommandValidator : AbstractValidator<DeleteSystemWatcherCommand>
    {
        public DeleteSystemWatcherCommandValidator()
        {
            this.CascadeMode = CascadeMode.Stop;

            this.RuleFor(x => x.Id)
                .LongId()
                .NotEqual(DataConstants.SystemWatcher.DefaultSystemWatcherId)
                .WithName(nameof(DeleteSystemWatcherCommand.Id));
        }
    }
}
