using EmployeeAPI.Entity.EntityModels;
using EmployeeAPI.Service.Contacts;
using EmployeeAPI.Web.Models.EmployeeDTos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmployeeAPI.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
         private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeDTO>>GetEmployeesList()
        {
            var employees= await _employeeService.GetAll();
            var list = new List<EmployeeDTO>();
            if (employees != null)
            {
                
               for(int i=0; i<employees.Count; i++)
                {
                    var employee = new Models.EmployeeDTos.EmployeeDTO();
                    employee.PostalCode = employees[i].PostalCode;
                    employee.Name = employees[i].Name;
                    employee.Salary= employees[i].Salary;
                    employee.Mobile= employees[i].Mobile;
                    employee.City= employees[i].City;
                    list.Add(employee);
                }
               return list;
            }
            return list;
           
        }
        [HttpGet("id")]
        public async Task<EmployeeDTO> GetEmployeeById(int id)
        {
            var employee=await _employeeService.GetById(id);
            var Employee = new EmployeeDTO();
            if (employee != null)
            {
                Employee.PostalCode = employee.PostalCode;
                Employee.Name = employee.Name;
                Employee.Salary = employee.Salary;
                Employee.Mobile = employee.Mobile;
                Employee.City = employee.City;
            }
            return Employee;
        }
        //[HttpPost]
        //public async Task AddEmployee(Employee employee)
        //{
        //    if(ModelState.IsValid)
        //    {
        //        await _employeeService.Add(employee);
        //        return await Ok();
        //    }
        //}
    }
}
