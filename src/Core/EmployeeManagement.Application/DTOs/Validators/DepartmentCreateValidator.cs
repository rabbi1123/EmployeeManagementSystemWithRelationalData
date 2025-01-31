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
    public class DepartmentCreateValidator : AbstractValidator<DepartmentCreateDto>
    {
        public DepartmentCreateValidator()
        {
            RuleFor(p => p.DepartmentName)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull()
                .MaximumLength(60).WithMessage("{PropertyName} must not exceed 60 characters.");

            
        }
    }
}
