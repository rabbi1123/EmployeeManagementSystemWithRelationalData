using AutoMapper;
using EmployeeManagement.Application.DTOs.Department;
using EmployeeManagement.Application.DTOs.Employee;
using EmployeeManagement.Application.Features.Department.Requests.Queries;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Handlers.Queries
{
    public class GetDepartmentDetailRequestHandler : IRequestHandler<GetDepartmentDetailRequest, DepartmentDto>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public GetDepartmentDetailRequestHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }
        public async Task<DepartmentDto> Handle(GetDepartmentDetailRequest request, CancellationToken cancellationToken)
        {
            var department = await departmentRepository.Get(request.Id);
            return mapper.Map<DepartmentDto>(department);
        }
    }
}
