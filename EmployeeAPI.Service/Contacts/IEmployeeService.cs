using EmployeeAPI.Entity.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Service.Contacts
{
    public interface IEmployeeService
    {
       public Task<Employee> GetById(int id);
       public Task<List<Employee>> GetAll();
       public Task<bool> Update(Employee Entity);
       public Task<bool> Delete(Employee Entity);
       public Task<bool> Add(Employee Entity);

    }
}
