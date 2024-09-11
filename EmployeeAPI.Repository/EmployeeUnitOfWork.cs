using EmployeeAPI.Repository.Contact;
using EmployeeAPI.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository
{
    public class EmployeeUnitOfWork : UnitOfWork, IEmployeeUnitOfWork
    {
        private readonly ApplicationDbContext _dbcontext;
        public EmployeeUnitOfWork(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _dbcontext = applicationDbContext;
        }

        public IEmployeeRepository EmployeeRepository
        {
            get
            {
                return new EmployeeRepository(_dbcontext);
            }
        }
    }
}
