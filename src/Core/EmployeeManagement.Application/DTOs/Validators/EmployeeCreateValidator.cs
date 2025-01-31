using EmployeeManagement.Application.DTOs.Department;
using EmployeeManagement.Application.DTOs.Employee;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Validators
{
    public class EmployeeCreateValidator : AbstractValidator<EmployeeCreateDto>
    {
        public EmployeeCreateValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull()
                .MaximumLength(60).WithMessage("{PropertyName} must not exceed 60 characters.");

            RuleFor(p => p.DepartmentId)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();

            RuleFor(p => p.Status)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull()
                .MaximumLength(60).WithMessage("{PropertyName} must not exceed 60 characters.");

        }
    }
}
