//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OMC2015.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class LOGIN
    {
        public int id { get; set; }
        public string uname { get; set; }
        public string password { get; set; }
        public int permissionid { get; set; }
        public string auditclass { get; set; }
        public bool islock { get; set; }
        public Nullable<int> DepartmentID { get; set; }
    }
}
