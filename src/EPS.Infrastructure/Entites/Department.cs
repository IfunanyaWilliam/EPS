
namespace EPS.Infrastructure.Entites
{
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Staff> Staffs { get; set; } = new List<Staff>();
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
