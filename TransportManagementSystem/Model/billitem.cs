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
    
    public partial class billitem
    {
        public int id { get; set; }
        public int bill_id { get; set; }
        public string item_name { get; set; }
        public decimal quantity { get; set; }
        public decimal charge_amount { get; set; }
        public string unit { get; set; }
        public int date { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public string delivered_location { get; set; }
        public Nullable<decimal> total_qty { get; set; }
        public decimal weight { get; set; }
        public decimal totalweight { get; set; }
        public Nullable<int> fiscalyear_id { get; set; }
    
        public virtual bill bill { get; set; }
        public virtual fiscalyear fiscalyear { get; set; }
    }
}
