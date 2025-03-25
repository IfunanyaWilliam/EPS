
namespace EPS.Infrastructure.Entites
{
    public class Employee
    {
        public Guid Id { get; set; }
        public Guid BeneficiaryId { get; set; }
        public Beneficiary Beneficiary { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string EnrollmentNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
