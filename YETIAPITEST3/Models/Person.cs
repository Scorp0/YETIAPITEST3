//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YETIAPITEST3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int PersonId { get; set; }
        public byte[] PersonImage { get; set; }
        public string PersonPhone { get; set; }
        public System.DateTime Birthdate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public int RoleId { get; set; }
        public int GenderId { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
