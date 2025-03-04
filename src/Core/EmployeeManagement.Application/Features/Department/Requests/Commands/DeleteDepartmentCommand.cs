﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features.Department.Requests.Commands
{
    public class DeleteDepartmentCommand : IRequest
    {
        public int Id { get; set; }
    }
}
