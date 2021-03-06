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
    
    public partial class tbl_expectation_register
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_expectation_register()
        {
            this.tbl_student_expectation_register = new HashSet<tbl_student_expectation_register>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string code { get; set; }
        public Nullable<double> fee { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<long> course_year_id { get; set; }
        public Nullable<long> period_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> subject_id { get; set; }
    
        public virtual tbl_course_year tbl_course_year { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_expectation_register> tbl_student_expectation_register { get; set; }
        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
        public virtual tbl_subject tbl_subject { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
    }
}
