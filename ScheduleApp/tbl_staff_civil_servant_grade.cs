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
    
    public partial class tbl_staff_civil_servant_grade
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<System.DateTime> from_date { get; set; }
        public Nullable<bool> is_current { get; set; }
        public Nullable<System.DateTime> to_date { get; set; }
        public Nullable<long> civil_servant_category_grade_id { get; set; }
        public Nullable<long> staff_id { get; set; }
    
        public virtual tbl_civil_servant_category_grade tbl_civil_servant_category_grade { get; set; }
        public virtual tbl_staff tbl_staff { get; set; }
    }
}