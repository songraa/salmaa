//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Faculty_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> DepId { get; set; }
    
        public virtual departmant departmant { get; set; }
    }
}
