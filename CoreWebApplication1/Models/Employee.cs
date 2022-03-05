using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("employees")]
    public partial class Employee
    {
        [Key]
        [Column("employee_id", TypeName = "integer(3)")]
        public long EmployeeId { get; set; }
        [Column("first_name", TypeName = "varchar(20)")]
        public string? FirstName { get; set; }
        [Column("last_name", TypeName = "varchar(25)")]
        public string? LastName { get; set; }
        [Column("email", TypeName = "varchar(25)")]
        public string? Email { get; set; }
        [Column("phone_number", TypeName = "varchar(20)")]
        public string? PhoneNumber { get; set; }
        [Column("hire_date", TypeName = "date")]
        public byte[]? HireDate { get; set; }
        [Column("job_id", TypeName = "varchar(10)")]
        public string JobId { get; set; } = null!;
        [Column("salary", TypeName = "decimal")]
        public byte[]? Salary { get; set; }
        [Column("commission_pct", TypeName = "number")]
        public byte[]? CommissionPct { get; set; }
        [Column("manager_id", TypeName = "integer(3)")]
        public long? ManagerId { get; set; }
        [Column("department_id", TypeName = "integer(3)")]
        public long? DepartmentId { get; set; }
        [Column("Avg_Salary", TypeName = "NUMERIC")]
        public byte[]? AvgSalary { get; set; }
    }
}
