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
    
    public partial class Student
    {
        public Student()
        {
            this.Issues = new HashSet<Issue>();
            this.LogRegisters = new HashSet<LogRegister>();
        }
    
        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Branch { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<int> maxbook { get; set; }
    
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<LogRegister> LogRegisters { get; set; }
    }
}
