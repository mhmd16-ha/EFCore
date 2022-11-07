using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Configuration
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Cofigure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(m => m.URL).IsRequired();
        }

        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            throw new NotImplementedException();
        }
    }
}
