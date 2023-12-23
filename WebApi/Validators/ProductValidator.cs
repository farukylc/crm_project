using FluentValidation;
using WebApi.Models;

namespace WebApi.Validators;

public class ProductValidator: AbstractValidator<Product>
{
    public ProductValidator()
    {
        RuleFor(x => x.ProductName).Length(50).WithMessage("İsim çok uzun aga");
    }
}