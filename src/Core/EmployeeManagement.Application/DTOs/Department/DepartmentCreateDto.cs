using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Department
{
    public class DepartmentCreateDto
    {
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public decimal? Budget { get; set; }
    }
}
