using EmployeeManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Department
{
    public class DepartmentDto : BaseDto
    {
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public decimal? Budget { get; set; }
    }
}
