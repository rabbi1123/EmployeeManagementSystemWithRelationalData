using EmployeeManagement.Application.DTOs.Employee;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Employee.Requests.Commands
{
    public class CreateEmployeeCommand() : IRequest<int>
    {
        public EmployeeCreateDto EmployeeCreateDto { get; set; }
    }
}
