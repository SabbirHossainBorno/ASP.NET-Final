//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.News = new HashSet<News>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Nullable<int> UserType { get; set; }
    
        public virtual ICollection<News> News { get; set; }
    }
}
