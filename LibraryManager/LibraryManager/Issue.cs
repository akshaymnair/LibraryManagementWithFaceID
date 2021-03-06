//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Issue
    {
        public int IssueId { get; set; }
        public string StudentId { get; set; }
        public int BookId { get; set; }
        public System.DateTime IssueDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> fine { get; set; }
    
        public virtual Book Book { get; set; }
        public virtual Student Student { get; set; }
    }
}
