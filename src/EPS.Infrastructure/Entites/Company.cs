using EPS.Domain.Company;


namespace EPS.Infrastructure.Entites
{
    public class Company
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public string CompanyType { get; set; }
        public string Industry { get; set; }
        public string RegistrationNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public CompanyStatus CompanyStatus { get; set; }
        public DateTime? ContractStartDate { get; set; }
        public DateTime? ContractEndDate { get; set; }
        public bool HasServiceLevelAgreement { get; set; }
        public List<Employee> Employees { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
