using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("countries")]
    public partial class Country
    {
        [Key]
        [Column("country_id", TypeName = "varchar(2)")]
        public string CountryId { get; set; } = null!;
        [Column("country_name", TypeName = "varchar(40)")]
        public string CountryName { get; set; } = null!;
        [Column("region_id", TypeName = "integer(2)")]
        public long RegionId { get; set; }
    }
}
