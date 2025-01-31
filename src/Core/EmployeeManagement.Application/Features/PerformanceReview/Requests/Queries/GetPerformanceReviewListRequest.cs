using EmployeeManagement.Application.DTOs.Employee;
using EmployeeManagement.Application.DTOs.PerformanceReview;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.PerformanceReview.Requests.Queries
{
    public class GetPerformanceReviewListRequest : IRequest<List<PerformanceReviewDto>>
    {
    }
}
