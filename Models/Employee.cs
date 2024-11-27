using System.ComponentModel.DataAnnotations;

namespace CBSManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }

        public string EmpName { get; set; }

        public DateTime DOB { get; set; }

        public string PhoneNo { get; set; }

        public string Position { get; set; }

        public decimal EmpSalary { get; set; }
    }
}
