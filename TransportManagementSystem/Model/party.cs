//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TransportManagementSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class party
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public party()
        {
            this.partiesledger_payments = new HashSet<partiesledger_payments>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public decimal due { get; set; }
        public decimal advance { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime upadated_at { get; set; }
        public Nullable<int> fiscalyear_id { get; set; }
    
        public virtual fiscalyear fiscalyear { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<partiesledger_payments> partiesledger_payments { get; set; }
    }
}
