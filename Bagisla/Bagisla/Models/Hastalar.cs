//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bagisla.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Hastalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Hastalar()
        {
            this.BagisVerens = new HashSet<BagisVeren>();
            this.Iletisims = new HashSet<Iletisim>();
            this.Mesajlars = new HashSet<Mesajlar>();
            this.Raporlars = new HashSet<Raporlar>();
        }
    
        public int Hasta_No { get; set; }
        public string Email { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public System.DateTime Dogum_Tarihi { get; set; }
        public string Saglik_Durumu { get; set; }
        public string Tel { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<int> DNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BagisVeren> BagisVerens { get; set; }
        public virtual Doktorlar Doktorlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Iletisim> Iletisims { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mesajlar> Mesajlars { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Raporlar> Raporlars { get; set; }
    }
}