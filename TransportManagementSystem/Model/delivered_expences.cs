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
    
    public partial class delivered_expences
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal amount { get; set; }
        public int vehicle_number { get; set; }
        public int date { get; set; }
        public Nullable<int> bill_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> sync_id { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual bill bill { get; set; }
        public virtual vehicle vehicle { get; set; }
    }
}
