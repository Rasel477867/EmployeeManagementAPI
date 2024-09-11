namespace EmployeeAPI.Entity.EntityModels
{
    public class Attedence:BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string MonthName { get;set; }
        public bool IsPresent {  get; set; }

    }
}