
namespace EPS.Infrastructure.Entites
{
    public class Statement
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public string EnrollmentNumber { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public decimal TotalContribuitions { get; set; }
        public decimal TotalWithdrawals { get; set; }
        public decimal AvailableBalance { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
