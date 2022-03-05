using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Table("locations")]
    public partial class Location
    {
        [Key]
        [Column("location_id", TypeName = "integer(4)")]
        public long LocationId { get; set; }
        [Column("street_address", TypeName = "varchar(25)")]
        public string StreetAddress { get; set; } = null!;
        [Column("postal_code", TypeName = "varchar(12)")]
        public string? PostalCode { get; set; }
        [Column("city", TypeName = "varchar(30)")]
        public string City { get; set; } = null!;
        [Column("state_province", TypeName = "varchar(12)")]
        public string? StateProvince { get; set; }
        [Column("country_id", TypeName = "varchar(2)")]
        public string? CountryId { get; set; }
    }
}
