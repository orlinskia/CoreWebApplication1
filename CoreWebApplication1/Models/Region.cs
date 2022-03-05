using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("regions")]
    public partial class Region
    {
        [Key]
        [Column("region_id", TypeName = "integer(2)")]
        public long RegionId { get; set; }
        [Column("region_name", TypeName = "varchar(25)")]
        public string RegionName { get; set; } = null!;
    }
}
