﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Employee
{
    public class EmployeeCreateDto
    {
        public string Name { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Position { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentId { get; set; }
        public string Status { get; set; }
    }
}
