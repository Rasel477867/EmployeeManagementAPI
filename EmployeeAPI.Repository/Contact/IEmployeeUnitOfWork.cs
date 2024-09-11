using EmployeeAPI.Repository.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Repository.Contact
{
    public interface IEmployeeUnitOfWork:IUnitOfWork
    {
        IEmployeeRepository EmployeeRepository { get; }
    }
}
