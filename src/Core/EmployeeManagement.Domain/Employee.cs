using EmployeeManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain
{
    public class Employee : BaseDomainEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentId { get; set; }
        public string Status { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public List<PerformanceReview> PerformanceReviews { get; set; }
    }
}
