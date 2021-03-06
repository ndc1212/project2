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
    
    public partial class tbl_student_semester_subject_exam_room
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_semester_subject_exam_room()
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
        public string examCode { get; set; }
        public Nullable<bool> isExempt { get; set; }
        public string markingCode { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<long> semester_subject_exam_room_id { get; set; }
        public Nullable<long> exam_status_id { get; set; }
        public Nullable<long> special_point_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<long> student_course_subject_id { get; set; }
        public Nullable<long> test_bag_id { get; set; }
        public Nullable<bool> is_arranged_room { get; set; }
        public Nullable<long> student_exam_id { get; set; }
    
        public virtual tbl_exam_status tbl_exam_status { get; set; }
        public virtual tbl_semester_subject_exam_room tbl_semester_subject_exam_room { get; set; }
        public virtual tbl_special_point tbl_special_point { get; set; }
        public virtual tbl_student tbl_student { get; set; }
        public virtual tbl_student_course_subject tbl_student_course_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }
        public virtual tbl_test_bag tbl_test_bag { get; set; }
    }
}
