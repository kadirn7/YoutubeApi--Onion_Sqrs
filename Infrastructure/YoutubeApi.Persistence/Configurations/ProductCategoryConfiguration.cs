﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });
            builder.HasOne(p=>p.Product).WithMany
                (pc=>pc.ProductCategories).HasForeignKey(pc=>pc.ProductId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(c => c.Category).WithMany
                (pc => pc.ProductCategories).HasForeignKey(cc => cc.CategoryId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
