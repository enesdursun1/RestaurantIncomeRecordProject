using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Table;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Category;

public class CreateTableValidator : AbstractValidator<CreateTableRequest>
{
   
    public CreateTableValidator()
    {
        RuleFor(p => p.Name).NotEmpty();






    }

}
