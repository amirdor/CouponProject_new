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
    
    public partial class User
    {
        public User()
        {
            this.SocialNetworkProfiles = new HashSet<SocialNetworkProfile>();
            this.UsersCoupon_Alert = new HashSet<UsersCoupon_Alert>();
        }
    
        public int Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    
        public virtual Costumer Costumer { get; set; }
        public virtual Firm_Owner Firm_Owner { get; set; }
        public virtual ICollection<SocialNetworkProfile> SocialNetworkProfiles { get; set; }
        public virtual Sytem_Admin Sytem_Admin { get; set; }
        public virtual ICollection<UsersCoupon_Alert> UsersCoupon_Alert { get; set; }
    }
}
