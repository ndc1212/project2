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
    
    public partial class tbl_student_course_subject_edited
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<int> change_time { get; set; }
        public Nullable<bool> is_lock { get; set; }
        public Nullable<long> register_period_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
    
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
        public virtual tbl_student tbl_student { get; set; }
    }
}
