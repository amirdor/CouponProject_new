//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coupon_Alert
    {
        public int Id { get; set; }
        public int alert_type { get; set; }
        public int coupon_Id { get; set; }
        public string text { get; set; }
    
        public virtual AlertType AlertType { get; set; }
        public virtual Coupon Coupon { get; set; }
    }
}
