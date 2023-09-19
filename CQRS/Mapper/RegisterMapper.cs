using AutoMapper;
using CQRS.Entities;
using CQRS.Handlers.Commands.Requests;
using CQRS.Handlers.Commands.Responses;
using CQRS.Handlers.Queries.Responses;

namespace CQRS.Mapper;

public class RegisterMapper : Profile
{
    public RegisterMapper()
    {
        CreateMap<Product, GetProductByIdQueryResponse>();
        CreateMap<Product, GetProductsQueryResponse>();
        CreateMap<Product, UpdateProductCommandResponse>();
        CreateMap<CreateProductCommandRequest, Product>();
        CreateMap<UpdateProductCommandRequest, Product>();
    }
}