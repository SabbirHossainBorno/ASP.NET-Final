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
    
    public partial class News
    {
        public int ID { get; set; }
        public string PublishedDate { get; set; }
        public string Headline { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Body { get; set; }
        public Nullable<int> AuthId { get; set; }
        public Nullable<int> ReID { get; set; }
        public Nullable<int> CmID { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Comment Comment { get; set; }
        public virtual React React { get; set; }
        public virtual User User { get; set; }
    }
}