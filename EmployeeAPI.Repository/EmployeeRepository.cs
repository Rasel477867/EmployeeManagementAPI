using EmployeeAPI.Entity.EntityModels;
using EmployeeAPI.Repository.Contact;
using EmployeeAPI.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _dbcontext;
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _dbcontext = db;
        }
    }
}
