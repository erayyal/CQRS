using MediatR;

namespace CQRS.Handlers.Commands.Requests;

public class CreateProductCommandRequest : IRequest<Guid>
{
    public string Name { get; set; }
}