namespace _DbEntities.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class Userinfo
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string Surname { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(30)]
        public string Job { get; set; }
        public string JobStatus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(100)]
        public string HealtyhSituation { get; set; }
        [StringLength(200)]
        public string Desciption { get; set; }

        [StringLength(30)]
        public string BloodGroup { get; set; }
        public int? Count { get; set; }

        public string ProfilImage { get; set; }
        public string IdentityNumber { get; set; }

        public string City { get; set; }
        public string District { get; set; }




    }
}
