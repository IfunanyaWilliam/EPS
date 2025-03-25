
namespace EPS.Infrastructure.Entites
{
    public class Beneficiary
    {
        public Guid Id { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public string Title { get; set; }
        public string Relationship { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateEnrolled { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
