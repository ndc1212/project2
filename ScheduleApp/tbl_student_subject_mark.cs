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
    
    public partial class tbl_student_subject_mark
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_subject_mark()
        {
            this.tbl_student_mark = new HashSet<tbl_student_mark>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string char_mark { get; set; }
        public Nullable<int> examRound { get; set; }
        public Nullable<int> input_method { get; set; }
        public Nullable<bool> is_accepted { get; set; }
        public Nullable<bool> is_counted { get; set; }
        public Nullable<bool> is_published { get; set; }
        public Nullable<double> mark { get; set; }
        public Nullable<double> mark4 { get; set; }
        public string note { get; set; }
        public Nullable<int> result { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<int> study_time { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<long> subject_id { get; set; }
    
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_student tbl_student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }
        public virtual tbl_subject tbl_subject { get; set; }
    }
}