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
    
    public partial class tbl_training_base_semester_subject
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<int> numberCourseSubject { get; set; }
        public Nullable<long> semester_subject_id { get; set; }
        public Nullable<long> training_base_id { get; set; }
    
        public virtual tbl_semester_subject tbl_semester_subject { get; set; }
        public virtual tbl_training_base tbl_training_base { get; set; }
    }
}
