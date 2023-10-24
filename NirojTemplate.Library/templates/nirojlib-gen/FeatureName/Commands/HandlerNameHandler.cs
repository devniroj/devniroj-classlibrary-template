using NirojTemplate.Library.Application.Common.Interfaces;

namespace NirojTemplate.Library.Application.FeatureName.Commands.CleanArchitectureUseCase;

public record CleanArchitectureUseCaseCommand : IRequest<object>
{
}

public class CleanArchitectureUseCaseCommandValidator : AbstractValidator<CleanArchitectureUseCaseCommand>
{
    public CleanArchitectureUseCaseCommandValidator()
    {
    }
}

public class CleanArchitectureUseCaseCommandHandler : IRequestHandler<CleanArchitectureUseCaseCommand, object>
{
    private readonly IApplicationDbContext _context;

    public CleanArchitectureUseCaseCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<object> Handle(CleanArchitectureUseCaseCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
