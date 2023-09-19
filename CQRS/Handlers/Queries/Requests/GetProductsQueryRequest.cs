using CQRS.Handlers.Queries.Responses;
using MediatR;

namespace CQRS.Handlers.Queries.Requests;

public class GetProductsQueryRequest : IRequest<List<GetProductsQueryResponse>>
{
}