namespace _DbEntities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mesajlar")]
    public partial class Mesajlar
    {
        public Guid ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Ad { get; set; }

        [Required]
        [StringLength(20)]
        public string Soyad { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Konu { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }
    }
}
