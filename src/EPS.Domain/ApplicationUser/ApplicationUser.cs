
namespace EPS.Domain.ApplicationUser
{
    public class ApplicationUser
    {
        public ApplicationUser(
            Guid id,
            Guid? companyId,
            Guid? employeeId,
            string? firstName,
            string? middleName,
            string? lastName,
            string email,
            DateTime dateCreated,
            DateTime? dateModified,
            bool isDeleted)
        {
            Id = id;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Email = email;
            DateCreated = dateCreated;
            DateModified = dateModified;
            IsDeleted = isDeleted;
        }

        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public UserType UserType { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
