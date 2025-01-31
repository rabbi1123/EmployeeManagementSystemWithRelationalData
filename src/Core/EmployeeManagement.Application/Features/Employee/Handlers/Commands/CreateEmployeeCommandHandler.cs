﻿using AutoMapper;
using EmployeeManagement.Application.DTOs.Validators;
using EmployeeManagement.Application.Features.Employee.Requests.Commands;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EmployeeManagement.Application.Features.Employee.Handlers.Commands
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public CreateEmployeeCommandHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }
        public async Task<int> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var validator = new EmployeeCreateValidator();
            var validationResult = await validator.ValidateAsync(request.EmployeeCreateDto);
            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }
            var employee = mapper.Map<EmployeeManagement.Domain.Employee>(request.EmployeeCreateDto);
            employee = await employeeRepository.Add(employee);
            return employee.Id;
        }
    }
}
