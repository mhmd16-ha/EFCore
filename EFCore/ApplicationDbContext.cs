using EFCore.Configuration;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore
{
    public class ApplicationDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCore;Integrated Security=True;");
        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
         new BlogEntityTypeConfiguration().Cofigure(modelBuilder.Entity<Blog>());

        public DbSet<Blog> Blogs { get; set; }

    }
}
