using FluentValidation.Validators;

namespace CashFlow.Application.UseCases.Users
{
    public class PasswordValidator : PropertyValidator
    {
        public PasswordValidator() : base("A senha é inválida.")
        {
        }

        protected override bool IsValid(PropertyValidatorContext context)
        {
            var password = context.PropertyValue as string;

            if (string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            return password.Length >= 8;
        }
    }
}

