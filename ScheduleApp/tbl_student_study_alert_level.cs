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
    
    public partial class tbl_student_study_alert_level
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string note { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<long> study_alert_condition_id { get; set; }
        public Nullable<long> study_alert_level_id { get; set; }
    
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_student tbl_student { get; set; }
        public virtual tbl_study_alert_level tbl_study_alert_level { get; set; }
        public virtual tbl_study_alert_condition tbl_study_alert_condition { get; set; }
    }
}
