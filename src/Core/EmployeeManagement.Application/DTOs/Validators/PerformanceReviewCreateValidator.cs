using EmployeeManagement.Application.DTOs.Employee;
using EmployeeManagement.Application.DTOs.PerformanceReview;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Validators
{
    public class PerformanceReviewCreateValidator : AbstractValidator<PerformanceReviewCreateDto>
    {
        public PerformanceReviewCreateValidator()
        {
            RuleFor(p => p.EmployeeId)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();

            RuleFor(p => p.ReviewScore)
                .NotEmpty().WithMessage("{PropertyName} is Required.")
                .NotNull();
        }
    }
}
