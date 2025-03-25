
namespace EPS.Infrastructure.Entites
{
    public class AccountDetail
    {
        public int Id { get; set; }
        public Guid? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public Guid? BeneficiaryId { get; set; }
        public Beneficiary? Beneficiary { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string Bank {  get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
