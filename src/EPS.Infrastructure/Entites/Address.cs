
namespace EPS.Infrastructure.Entites
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string LandMark { get; set; }
        public string LocalGovernment { get; set; }
        public string State { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
