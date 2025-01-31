using AutoMapper;
using EmployeeManagement.Application.DTOs.Employee;
using EmployeeManagement.Application.DTOs.PerformanceReview;
using EmployeeManagement.Application.Features.Employee.Requests.Queries;
using EmployeeManagement.Application.Features.PerformanceReview.Requests.Queries;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.PerformanceReview.Handlers.Queries
{
    public class GetPerformanceReviewDetailRequestHandler : IRequestHandler<GetPerformanceReviewDetailRequest, PerformanceReviewDto>
    {
        private readonly IPerformanceReviewRepository performanceReviewRepository;
        private readonly IMapper mapper;

        public GetPerformanceReviewDetailRequestHandler(IPerformanceReviewRepository performanceReviewRepository, IMapper mapper)
        {
            this.performanceReviewRepository = performanceReviewRepository;
            this.mapper = mapper;
        }
        public async Task<PerformanceReviewDto> Handle(GetPerformanceReviewDetailRequest request, CancellationToken cancellationToken)
        {
            var review = await performanceReviewRepository.Get(request.Id);
            return mapper.Map<PerformanceReviewDto>(review);
        }
    }
}
