﻿using AutoMapper;
using EmployeeManagement.Application.DTOs.Employee;
using EmployeeManagement.Application.Features.Employee.Requests.Queries;
using EmployeeManagement.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Employee.Handlers.Queries
{
    public class GetEmployeeDetailRequestHandler : IRequestHandler<GetEmployeeDetailRequest, EmployeeDto>
    {
        private readonly IEmployeeRepository employeeRepository;
        private readonly IMapper mapper;

        public GetEmployeeDetailRequestHandler(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            this.employeeRepository = employeeRepository;
            this.mapper = mapper;
        }
        public async Task<EmployeeDto> Handle(GetEmployeeDetailRequest request, CancellationToken cancellationToken)
        {
            var employee = await employeeRepository.Get(request.Id);
            return mapper.Map<EmployeeDto>(employee);
        }
    }
}
