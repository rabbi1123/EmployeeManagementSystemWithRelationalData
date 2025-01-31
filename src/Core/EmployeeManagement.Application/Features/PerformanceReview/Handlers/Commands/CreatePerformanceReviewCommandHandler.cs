using AutoMapper;
using EmployeeManagement.Application.DTOs.Validators;
using EmployeeManagement.Application.Features.Employee.Requests.Commands;
using EmployeeManagement.Application.Features.PerformanceReview.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.PerformanceReview.Handlers.Commands
{
    public class CreatePerformanceReviewCommandHandler : IRequestHandler<CreatePerformanceReviewCommand, int>
    {
        private readonly IPerformanceReviewRepository performanceReviewRepository;
        private readonly IMapper mapper;

        public CreatePerformanceReviewCommandHandler(IPerformanceReviewRepository performanceReviewRepository, IMapper mapper)
        {
            this.performanceReviewRepository = performanceReviewRepository;
            this.mapper = mapper;
        }
        public async Task<int> Handle(CreatePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            var validator = new PerformanceReviewCreateValidator();
            var validationResult = await validator.ValidateAsync(request.PerformanceReviewCreateDto);
            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }
            var review = mapper.Map<EmployeeManagement.Domain.PerformanceReview>(request.PerformanceReviewCreateDto);
            review = await performanceReviewRepository.Add(review);
            return review.Id;
        }
    }
}
