using Business.Dtos.Requests.Table;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation.Category;

public class UpdateTableValidator : AbstractValidator<UpdateTableRequest>
{

    public UpdateTableValidator()
    {
        RuleFor(p => p.Name).NotEmpty();






    }

}
