//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace testdelete.DbConnection
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public Student()
        {
            this.Marks = new HashSet<Mark>();
        }
    
        public int Id { get; set; }
        public string RNo { get; set; }
        public string studentName { get; set; }
        public Nullable<int> SudentInfoID { get; set; }
    
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual SchoolInfo SchoolInfo { get; set; }
    }
}
