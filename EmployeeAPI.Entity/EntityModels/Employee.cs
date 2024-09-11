using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAPI.Entity.EntityModels
{
    public class Employee:BaseEntity
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string City {  get; set; }
        public string Mobile { get; set; }
        public string PostalCode { get; set; }
        public virtual List<Attedence> Attendences { get; set; }

      
    }
}
