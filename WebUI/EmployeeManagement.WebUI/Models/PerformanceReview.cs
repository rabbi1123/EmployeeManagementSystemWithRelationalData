namespace EmployeeManagement.WebUI.Models
{
    public class PerformanceReview
    {
        public int? Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime ReviewDate { get; set; }
        public int ReviewScore { get; set; }
        public string? ReviewNotes { get; set; }
        public string? Status { get; set; }
    }
}
