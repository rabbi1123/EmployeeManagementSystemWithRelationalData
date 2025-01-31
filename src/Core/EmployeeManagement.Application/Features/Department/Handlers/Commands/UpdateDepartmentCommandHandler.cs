using AutoMapper;
using EmployeeManagement.Application.Features.Department.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Handlers.Commands
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, Unit>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public UpdateDepartmentCommandHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await departmentRepository.Get(request.Department.Id);
            mapper.Map(request.Department, department);
            await departmentRepository.Update(department);
            return Unit.Value;
        }
    }
}
