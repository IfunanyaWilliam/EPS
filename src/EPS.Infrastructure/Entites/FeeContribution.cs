
namespace EPS.Infrastructure.Entites
{
    public class FeeContribution
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid PlanId { get; set; }
        public Plan Plan { get; set; }
        public string EnrollmentNumber { get; set; }
        public decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
