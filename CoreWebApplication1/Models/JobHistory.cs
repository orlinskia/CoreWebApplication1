using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Keyless]
    [Table("job_history")]
    public partial class JobHistory
    {
        [Column("employee_id", TypeName = "integer(3)")]
        public long EmployeeId { get; set; }
        [Column("start_date", TypeName = "date")]
        public byte[] StartDate { get; set; } = null!;
        [Column("end_date", TypeName = "date")]
        public byte[] EndDate { get; set; } = null!;
        [Column("job_id", TypeName = "varchar(10)")]
        public string JobId { get; set; } = null!;
        [Column("department_id", TypeName = "integer(3)")]
        public long DepartmentId { get; set; }
    }
}
