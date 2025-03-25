
namespace EPS.Infrastructure.Entites
{
    public class CompanyReview
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Company Company { get; set; }
        public Guid ReviewerId { get; set; }
        public string? ReviewerComment { get; set; }
        public Guid ApproverId { get; set; }
        public string? ApporverComment { get; set; }
        public DateTime DateReviewed { get; set; }
        public DateTime? DateApproved { get; set; }

        //for approving, if the staff is an Admin user can approve same time.
    }
}
