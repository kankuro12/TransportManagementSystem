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
    
    public partial class incomecategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public incomecategory()
        {
            this.incomes = new HashSet<income>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> date { get; set; }
        public Nullable<int> firscalyear_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<int> fiscalyear_id { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual fiscalyear fiscalyear { get; set; }
        public virtual fiscalyear fiscalyear1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<income> incomes { get; set; }
    }
}
