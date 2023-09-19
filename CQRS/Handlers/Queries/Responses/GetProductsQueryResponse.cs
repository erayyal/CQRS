namespace CQRS.Handlers.Queries.Responses;

public class GetProductsQueryResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}