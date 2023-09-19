using CQRS.Handlers.Commands.Responses;
using MediatR;

namespace CQRS.Handlers.Commands.Requests;

public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}