//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ingradient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingradient()
        {
            this.Upgrade_Ingredients = new HashSet<Upgrade_Ingredients>();
        }
    
        public int Ing_Id { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Quentity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Upgrade_Ingredients> Upgrade_Ingredients { get; set; }
    }
}