using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.PerformanceReview.Requests.Commands
{
    public class DeletePerformanceReviewCommand : IRequest
    {
        public int Id { get; set; }
    }
}
