//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_position
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> department_id { get; set; }
        public Nullable<long> title_id { get; set; }
    
        public virtual tbl_department tbl_department { get; set; }
        public virtual tbl_position_title tbl_position_title { get; set; }
    }
}
