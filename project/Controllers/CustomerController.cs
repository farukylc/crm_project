using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Models;
using project.Repositories;

namespace project.Controllers;

public class CustomerController: Controller
{
    //Dependency Injection
    private readonly RepositoryContext _context;

    public CustomerController(RepositoryContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var model = _context.Customers.ToList();
        return View(model);
    }
}
//4.9