using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Repositories;

public class RepositoryContext:DbContext
{
    public RepositoryContext(DbContextOptions options): base(options)
    {
        
    }
    
    
    public DbSet<Customer> Customers { get; set; }
}