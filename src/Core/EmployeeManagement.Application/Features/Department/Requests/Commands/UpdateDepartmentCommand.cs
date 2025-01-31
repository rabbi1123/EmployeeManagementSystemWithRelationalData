using EmployeeManagement.Application.DTOs.Department;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Requests.Commands
{
    public class UpdateDepartmentCommand : IRequest<Unit>
    {
        public DepartmentDto Department { get; set; }
    }
}
