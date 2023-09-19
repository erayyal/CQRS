using CQRS.Handlers.Queries.Responses;
using MediatR;

namespace CQRS.Handlers.Queries.Requests;

public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
{
    public Guid Id { get; set; }
}