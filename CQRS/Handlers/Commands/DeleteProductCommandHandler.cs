using AutoMapper;
using CQRS.Handlers.Commands.Requests;
using CQRS.Repositories;
using MediatR;

namespace CQRS.Handlers.Commands;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommandRequest, bool>
{
    private readonly IProductRepository _productRepository;
    private readonly IMapper _mapper;

    public DeleteProductCommandHandler(IProductRepository productRepository, IMapper mapper)
    {
        _productRepository = productRepository;
        _mapper = mapper;
    }

    public Task<bool> Handle(DeleteProductCommandRequest request, CancellationToken cancellationToken)
    {
        var isDeleted = _productRepository.DeleteProduct(request.Id);
        return Task.FromResult(isDeleted);
    }
}