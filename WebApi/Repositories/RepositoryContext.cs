﻿using Microsoft.EntityFrameworkCore;
using WebApi.Models;
using WebApi.Repositories.Config;

namespace WebApi.Repositories
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) :
            base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new CommentConfig());
        }
    }
}
