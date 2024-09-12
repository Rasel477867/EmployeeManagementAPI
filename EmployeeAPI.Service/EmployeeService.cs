using EmployeeAPI.Entity.EntityModels;
using EmployeeAPI.Repository.Contact;
using EmployeeAPI.Service.Contacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Service
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeUnitOfWork _unitofwork;
        public EmployeeService(IEmployeeUnitOfWork employeeUnitOfWork)
        {
            _unitofwork = employeeUnitOfWork;
        }


        public async Task<List<Employee>> GetAll()
        {
           return await _unitofwork.EmployeeRepository.GetAll();
        }

        public async Task<Employee> GetById(int id)
        {
            return await _unitofwork.EmployeeRepository.GetById(id);
        }

        async Task<bool> IEmployeeService.Add(Employee Entity)
        {
            await _unitofwork.EmployeeRepository.Add(Entity);
            return await _unitofwork.CompleteAsync();
        }

        async Task<bool> IEmployeeService.Delete(Employee Entity)
        {
           await _unitofwork.EmployeeRepository.Delete(Entity);
            return await _unitofwork.CompleteAsync();
        }

        async Task<bool> IEmployeeService.Update(Employee Entity)
        {
            await _unitofwork.EmployeeRepository.Update(Entity);
            return await _unitofwork.CompleteAsync();
        }
    }
}
