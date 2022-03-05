using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Keyless]
    [Table("department")]
    public partial class Department1
    {
        [Column("department_id")]
        public string? DepartmentId { get; set; }
        [Column("department_name")]
        public string? DepartmentName { get; set; }
        [Column("manager_id")]
        public string? ManagerId { get; set; }
        [Column("location_id")]
        public string? LocationId { get; set; }
    }
}
