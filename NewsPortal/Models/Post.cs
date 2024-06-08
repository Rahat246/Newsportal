//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsPortal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Post
    {
        public long id { get; set; }
        public string meta_title { get; set; }
        public string meta_keyword { get; set; }
        public string meta_description { get; set; }
        public string title { get; set; }
        public string slug { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
        public Nullable<long> category_id { get; set; }
        public Nullable<long> sub_category_id { get; set; }
        public Nullable<int> views { get; set; }
        public Nullable<long> comments { get; set; }
        public Nullable<long> writer_id { get; set; }
        public Nullable<int> status { get; set; }
        public bool main_news { get; set; }
        public Nullable<bool> exclusive_news { get; set; }
        public Nullable<System.DateTime> RecordDate { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual Newsletter Newsletter { get; set; }
        public virtual Sub_Category Sub_Category { get; set; }
    }
}
