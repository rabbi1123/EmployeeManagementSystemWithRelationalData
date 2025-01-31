using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Domain;

namespace EmployeeManagement.Application.Persistence.Contracts
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
    }
}
