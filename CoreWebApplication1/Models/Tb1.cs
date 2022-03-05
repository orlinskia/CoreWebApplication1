using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace CoreWebApplication1.Models
{
    [Keyless]
    [Table("tb1")]
    public partial class Tb1
    {
        [Column("c1", TypeName = "INT")]
        public long? C1 { get; set; }
        [Column("c2", TypeName = "CHAR(5)")]
        public string? C2 { get; set; }
        [Column("c3", TypeName = "FLOAT")]
        public double? C3 { get; set; }
    }
}
