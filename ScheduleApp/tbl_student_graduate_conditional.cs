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
    
    public partial class tbl_student_graduate_conditional
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<bool> is_lock { get; set; }
        public Nullable<double> mark { get; set; }
        public Nullable<double> mark4 { get; set; }
        public Nullable<int> number_of_credit { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> criteria_id { get; set; }
        public Nullable<long> education_program_id { get; set; }
        public Nullable<long> student_id { get; set; }
    
        public virtual tbl_criteria_search_student tbl_criteria_search_student { get; set; }
        public virtual tbl_education_program tbl_education_program { get; set; }
        public virtual tbl_student tbl_student { get; set; }
    }
}
