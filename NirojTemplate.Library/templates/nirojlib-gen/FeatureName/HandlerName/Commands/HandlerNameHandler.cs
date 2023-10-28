namespace NirojTemplate.Library.Application.FeatureName.HandlerName.Commands;

public class HandlerNameCommandValidator : AbstractValidator<HandlerNameCommand>
{
    public HandlerNameCommandValidator()
    {
    }
}

public class HandlerNameCommandHandler : IRequestHandler<HandlerNameCommand, object>
{

    public HandlerNameCommandHandler()
    {
    }

    public async Task<object> Handle(HandlerNameCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
