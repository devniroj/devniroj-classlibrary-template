
namespace NirojTemplate.Library.Application.FeatureName.HandlerName.Queries;



public class HandlerNameQueryValidator : AbstractValidator<HandlerNameQuery>
{
    public HandlerNameQueryValidator()
    {
    }
}

public class HandlerNameQueryHandler : IRequestHandler<HandlerNameQuery, object>
{
    private readonly IApplicationDbContext _context;

    public HandlerNameQueryHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<object> Handle(HandlerNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
