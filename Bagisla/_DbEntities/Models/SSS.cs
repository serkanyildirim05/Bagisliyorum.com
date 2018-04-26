namespace _DbEntities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SSS")]
    public partial class SSS
    {
        [Key]
        public int Soru_id { get; set; }

        [StringLength(140)]
        public string Soru { get; set; }

        [StringLength(140)]
        public string Cevap { get; set; }
    }
}
