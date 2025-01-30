using EmployeeManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain
{
    public class Department : BaseDomainEntity
    {
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public decimal? Budget { get; set; }

        [ForeignKey("ManagerId")]
        public Employee Employee { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
