﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Aplication.Interfaces.UnitOfWorks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Aplication.Features.Products.Command.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest>
    {
        private readonly IUnitOfWork unitOfWork;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new(request.Title, request.Description, request.BrandId, request.Price, request.Discount);
            await unitOfWork.GetWriteRepository<Product>().AddAsync(product);
            if( await unitOfWork.SaveAsync()>0)                                     // ilişkili tablolar için 2 defa saveAsync yaparız birinde
                                                                                    // product tablosu diğerinde ilişki tablosu save edilir.
            {   
                foreach (var categoryId in request.CategoryIds)
                {
                    await unitOfWork.GetWriteRepository<ProductCategory>().AddAsync(new()
                    {
                        ProductId=product.Id,
                        CategoryId=categoryId,
                    });
                }
                await unitOfWork.SaveAsync();
            }

        }
    }
}
