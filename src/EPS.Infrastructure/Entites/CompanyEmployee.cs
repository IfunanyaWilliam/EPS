
using EPS.Domain.Employee;

namespace EPS.Infrastructure.Entites
{
    public class CompanyEmployee
    {
        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public Company? Company { get; set; }
        public string CompanyName { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public EmploymentStatus EmploymentStatus { get; set; }
        public DateTime DateOfEnrollment { get; set; }
        public DateTime? EndOfEmployment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
