using AutoMapper;
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
    public class DeletePerformanceReviewCommandHandler : IRequestHandler<DeletePerformanceReviewCommand>
    {
        private readonly IPerformanceReviewRepository performanceReviewRepository;
        private readonly IMapper mapper;

        public DeletePerformanceReviewCommandHandler(IPerformanceReviewRepository performanceReviewRepository, IMapper mapper)
        {
            this.performanceReviewRepository = performanceReviewRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeletePerformanceReviewCommand request, CancellationToken cancellationToken)
        {
            EmployeeManagement.Domain.PerformanceReview review = await performanceReviewRepository.Get(request.Id);
            review.Status = "inactive";
            await performanceReviewRepository.Update(review);
            return Unit.Value;
        }
    }
}
