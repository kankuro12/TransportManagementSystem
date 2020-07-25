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
    
    public partial class customerpaid
    {
        public int id { get; set; }
        public Nullable<int> customer_id { get; set; }
        public Nullable<int> date { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<decimal> due { get; set; }
        public string issuedby { get; set; }
        public Nullable<int> firscalyear_id { get; set; }
        public Nullable<int> tax_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public Nullable<int> sync_id { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual customer customer { get; set; }
        public virtual fiscalyear fiscalyear { get; set; }
        public virtual tax tax { get; set; }
    }
}
