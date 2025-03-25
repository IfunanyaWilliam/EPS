
namespace EPS.Infrastructure.Entites
{
    using Domain.Employee;


    public class Staff
    {
        public Guid Id { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfEmployment { get; set; }
        public DateTime? EndOfEmployment { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
