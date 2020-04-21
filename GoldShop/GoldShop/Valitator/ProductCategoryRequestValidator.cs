using FluentValidation;
using GoldShop.DTOs;

namespace GoldShop.Valitator
{
    public class ProductCategoryRequestValidator : AbstractValidator<ProductCategoryRequest>
    {
        public ProductCategoryRequestValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(50);

            RuleFor(x => x.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);
        }
    }
}
