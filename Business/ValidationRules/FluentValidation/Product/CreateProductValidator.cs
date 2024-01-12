using Business.Dtos.Requests.Product;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation.Product;

public class CreateProductValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün ismi boş olamaz !");
        RuleFor(p => p.Price).NotNull().WithMessage("Ürün fiyatı boş olamaz !"); 
        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı boş olamaz !");
        RuleFor(p => p.CategoryId).NotNull().WithMessage("Kategori seçiniz !"); 
        RuleFor(p => p.CategoryId).GreaterThan(0).WithMessage("Kategori seçiniz !");



    }

}
