using EmployeeManagement.Application.DTOs.Department;
using EmployeeManagement.Application.DTOs.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Requests.Queries
{
    public class GetDepartmentListRequest : IRequest<List<DepartmentDto>>
    {
    }
}
