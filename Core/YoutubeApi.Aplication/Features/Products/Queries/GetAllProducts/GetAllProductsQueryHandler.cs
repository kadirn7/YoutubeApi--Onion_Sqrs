﻿using MediatR;
using YoutubeApi.Aplication.Features.Products.Queries.GetAllProducts;
using YoutubeApi.Aplication.Interfaces.Repositories.UnitOfWorks;
using YoutubeApi.Domain.Entities;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
{
    private readonly IUnitOfWork unitOfWork;

    
    public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork ;
    }

    public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
    {
        var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();

        List<GetAllProductsQueryResponse> response = new();
        foreach (var product in products)
        {
            response.Add(new GetAllProductsQueryResponse
            {
                Title = product.Title,
                Description = product.Description,
                Discount = product.Discount,
                Price = product.Price - (product.Price * product.Discount / 100),
            });
        }
        return response;
    }
}
