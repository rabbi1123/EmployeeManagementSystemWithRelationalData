using AutoMapper;
using EmployeeManagement.Application.DTOs.Validators;
using EmployeeManagement.Application.Features.Department.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManagement.Application.Features.Department.Handlers.Commands
{
    public class CreateDepartmentRequestHandler : IRequestHandler<CreateDepartmentCommand, int>
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly IMapper mapper;

        public CreateDepartmentRequestHandler(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            this.departmentRepository = departmentRepository;
            this.mapper = mapper;
        }
        public async Task<int> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var validator = new DepartmentCreateValidator();
            var validationResult = await validator.ValidateAsync(request.DepartmentCreateDto);
            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }
            var department = mapper.Map<EmployeeManagement.Domain.Department>(request.DepartmentCreateDto);
            department = await departmentRepository.Add(department);
            return department.Id;
        }
    }
}
