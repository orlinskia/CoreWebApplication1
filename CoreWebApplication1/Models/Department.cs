using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("departments")]
    public partial class Department
    {
        [Key]
        [Column("department_id", TypeName = "integer(3)")]
        public long DepartmentId { get; set; }
        [Column("depart_name", TypeName = "varchar(20)")]
        public string DepartName { get; set; } = null!;
        [Column("manager_id", TypeName = "integer(3)")]
        public long ManagerId { get; set; }
        [Column("location_id", TypeName = "integer(4)")]
        public long? LocationId { get; set; }
    }
}
