using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("jobs")]
    public partial class Job
    {
        [Key]
        [Column("job_id", TypeName = "varchar(10)")]
        public string JobId { get; set; } = null!;
        [Column("job_title", TypeName = "varchar(25)")]
        public string JobTitle { get; set; } = null!;
        [Column("min_salary", TypeName = "decimal")]
        public byte[]? MinSalary { get; set; }
        [Column("max_salary", TypeName = "decimal")]
        public byte[]? MaxSalary { get; set; }
    }
}
