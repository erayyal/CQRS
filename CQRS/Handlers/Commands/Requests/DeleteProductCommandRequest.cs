using MediatR;

namespace CQRS.Handlers.Commands.Requests;

public class DeleteProductCommandRequest : IRequest<bool>
{
    public Guid Id { get; set; }
}