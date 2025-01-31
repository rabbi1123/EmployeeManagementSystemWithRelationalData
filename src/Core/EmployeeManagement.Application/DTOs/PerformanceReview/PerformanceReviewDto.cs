using EmployeeManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.PerformanceReview
{
    public class PerformanceReviewDto : BaseDto
    {
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ReviewScore { get; set; }
        public string? ReviewNotes { get; set; }
    }
}
