using EPS.Domain.Contribution;

namespace EPS.Infrastructure.Entites
{
    public class Contribution
    {
        public Guid Id { get; set; }
        public Guid PlanId { get; set; }
        public Plan Plan { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public string EnrollmentNumber { get; set; }
        public decimal EmployeeContributionAmount { get; set; }
        public decimal? EmployerContributionAmount { get; set; }
        public ContributionType ContributionType { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
