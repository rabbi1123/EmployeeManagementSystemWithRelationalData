using AutoMapper;
using EmployeeManagement.Application.Features.Employee.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Employee.Handlers.Commands
{
    public class DeleteEmployeeCommandHandler : IRequestHandler<DeleteEmployeeCommand>
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public DeleteEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            EmployeeManagement.Domain.Employee employee = await employeeRepository.Get(request.Id);
            employee.Status = "inactive";
            await employeeRepository.Update(employee);
            return Unit.Value;
        }
    }
}
