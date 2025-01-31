namespace EmployeeManagement.WebUI.Models
{
    public class Employee
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Position { get; set; }
        public DateTime JoinDate { get; set; }
        public int DepartmentId { get; set; }
        public string? Status { get; set; }
    }
}
