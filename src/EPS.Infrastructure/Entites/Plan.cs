using System.Collections.Concurrent;

namespace EPS.Infrastructure.Entites
{
    public class Plan
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ContributionRules { get; set; }
        public string VestingSchedule { get; set; }
        public ConcurrentDictionary<decimal, decimal> EmployeeMatchPercentage { get; set; }
        public int MinimumEligibilityPeriod { get; set; }
        public decimal AdministrationFeesPercent { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
