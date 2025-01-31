using AutoMapper;
using EmployeeManagement.Application.Features.Department.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using EmployeeManagement.Domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Handlers.Commands
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public DeleteDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            EmployeeManagement.Domain.Department department = await departmentRepository.Get(request.Id);
            department.Status = "inactive";
            await departmentRepository.Update(department);
            return Unit.Value;
        }
    }
}
