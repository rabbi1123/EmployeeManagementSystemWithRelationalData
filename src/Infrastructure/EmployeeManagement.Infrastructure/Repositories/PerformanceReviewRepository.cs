using EmployeeManagement.Application.Persistence.Contracts;
using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class PerformanceReviewRepository : GenericRepository<PerformanceReview>, IPerformanceReviewRepository
    {
        private readonly EmployeeManagementContext dbContext;

        public PerformanceReviewRepository(EmployeeManagementContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
