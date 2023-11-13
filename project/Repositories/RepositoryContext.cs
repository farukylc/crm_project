using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Repositories;

public class RepositoryContext:DbContext
{
    public DbSet<Customer> Customers { get; set; }
}