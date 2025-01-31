namespace EmployeeManagement.WebUI.Models
{
    public class Department
    {
        public int? Id { get; set; }
        public string DepartmentName { get; set; }
        public int? ManagerId { get; set; }
        public decimal? Budget { get; set; }
        public string? Status { get; set; }

    }
}
