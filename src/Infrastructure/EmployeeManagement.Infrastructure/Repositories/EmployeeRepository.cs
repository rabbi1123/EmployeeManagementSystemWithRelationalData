using EmployeeManagement.Application.Persistence.Contracts;
using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        private readonly EmployeeManagementContext dbContext;

        public EmployeeRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
