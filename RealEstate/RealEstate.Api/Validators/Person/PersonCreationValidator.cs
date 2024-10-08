using FluentValidation;
using RealEstate.Api.Validators.Base;
using RealEstate.Api.Validators.Functions;
using RealEstate.Shared.Dtos;

namespace RealEstate.Api.Validators.Person;

public class PersonCreationValidator : CreateBaseValidator<CreatePersonDto>
{
    public PersonCreationValidator()
    {
        RuleFor(person => person.Name)
            .NotNull()
            .WithMessage("Person name shouldn't be null or empty")
            .NotEmpty()
            .WithMessage("Person name shouldn't be null or empty")
            .Must(ValidatorFunctions.HaveLengthEnought_Person)
            .WithMessage(
                "person name should have at least 8 characters length and two words minimum."
            );

        RuleFor(person => person.Email)
            .NotNull()
            .WithMessage("person email shouldn't be null or empty")
            .Must(ValidatorFunctions.BeAValidEmail)
            .WithMessage("person email should be a valid e-mail address");

        RuleFor(person => person.Phone)
            .NotNull()
            .WithMessage("person phone shouldn't be null or empty")
            .NotEmpty()
            .WithMessage("person phone shouldn't be null or empty")
            .Must(ValidatorFunctions.BeAValidPhone)
            .WithMessage("person phone must have only numebers and have 10-11 length");

        RuleFor(person => person.AddressId)
            .NotNull()
            .WithMessage("Person AddressId shouldn't be empty.");
    }
}
