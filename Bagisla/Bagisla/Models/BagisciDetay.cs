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
    
    public partial class BagisciDetay
    {
        public System.Guid ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Adres { get; set; }
        public string Meslek { get; set; }
        public Nullable<System.DateTime> DogumTarihi { get; set; }
        public Nullable<int> BagisSayisi { get; set; }
    
        public virtual aspnet_Users aspnet_Users { get; set; }
    }
}