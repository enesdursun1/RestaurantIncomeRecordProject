using Business.Dtos.Requests.Product;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Product;

public class UpdateProductValidator : AbstractValidator<UpdateProductRequest>
{
    public UpdateProductValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("Ürün ismi boş olamaz !");
        RuleFor(p => p.Price).NotNull().WithMessage("Ürün fiyatı boş olamaz !");
        RuleFor(p => p.Price).GreaterThan(0).WithMessage("Ürün fiyatı boş olamaz !");
        RuleFor(p => p.CategoryId).NotNull().WithMessage("Kategori seçiniz !");
        RuleFor(p => p.CategoryId).GreaterThan(0).WithMessage("Kategori seçiniz !");


    }

}