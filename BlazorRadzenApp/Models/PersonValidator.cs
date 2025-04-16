using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorRadzenApp.Models;

public class PersonValidator:AbstractValidator<Person>
{
    public PersonValidator()
    {

        RuleFor(x => x.Id)
           .NotEmpty()
           .WithMessage("Id is required");

        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("Name is required");

        RuleFor(x => x.Age)
            .NotEmpty()
            .WithMessage("Age is required")
            .GreaterThan(0)
            .WithMessage("Age must be greater than 0");
    }
}