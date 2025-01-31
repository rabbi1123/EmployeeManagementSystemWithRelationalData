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
    public class GetPerformanceReviewListRequestHandler : IRequestHandler<GetPerformanceReviewListRequest, List<PerformanceReviewDto>>
    {
        private readonly IPerformanceReviewRepository performanceReviewRepository;
        private readonly IMapper mapper;

        public GetPerformanceReviewListRequestHandler(IPerformanceReviewRepository performanceReviewRepository, IMapper mapper)
        {
            this.performanceReviewRepository = performanceReviewRepository;
            this.mapper = mapper;
        }
        public async Task<List<PerformanceReviewDto>> Handle(GetPerformanceReviewListRequest request, CancellationToken cancellationToken)
        {
            var reviewList = await performanceReviewRepository.GetAll();
            return mapper.Map<List<PerformanceReviewDto>>(reviewList);
        }
    }
}
