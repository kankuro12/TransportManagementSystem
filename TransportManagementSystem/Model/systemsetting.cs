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
    
    public partial class systemsetting
    {
        public int id { get; set; }
        public Nullable<int> fuscalyear_id { get; set; }
        public int currentdate { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public Nullable<int> syc_id { get; set; }
    
        public virtual fiscalyear fiscalyear { get; set; }
    }
}
