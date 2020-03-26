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
    
    public partial class tbl_course_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_course_subject()
        {
            this.tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
            this.tbl_semester_subject_exam_course_subject = new HashSet<tbl_semester_subject_exam_course_subject>();
            this.tbl_course_subject1 = new HashSet<tbl_course_subject>();
            this.tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            this.tbl_student_course_subject = new HashSet<tbl_student_course_subject>();
            this.tbl_timetable_detail = new HashSet<tbl_timetable_detail>();
            this.tbl_student_course_subject_history = new HashSet<tbl_student_course_subject_history>();
            this.tbl_course_subject_timetable = new HashSet<tbl_course_subject_timetable>();
            this.tbl_course_subject_timetable1 = new HashSet<tbl_course_subject_timetable>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string code { get; set; }
        public int courseSubjectType { get; set; }
        public Nullable<double> fee_per_credit { get; set; }
        public Nullable<double> fee_per_student { get; set; }
        public Nullable<bool> is_denied_all { get; set; }
        public Nullable<bool> is_fee_by_course_subject { get; set; }
        public Nullable<bool> is_grant_all { get; set; }
        public Nullable<bool> is_using_config { get; set; }
        public Nullable<int> max_student { get; set; }
        public Nullable<double> min_fee { get; set; }
        public Nullable<int> min_student { get; set; }
        public Nullable<double> number_hours { get; set; }
        public int numberStudent { get; set; }
        public string short_code { get; set; }
        public Nullable<double> total_fee { get; set; }
        public Nullable<long> enrollment_class_id { get; set; }
        public Nullable<long> learning_skill_id { get; set; }
        public Nullable<long> parent_id { get; set; }
        public Nullable<long> semester_subject_id { get; set; }
        public Nullable<long> teacher_id { get; set; }
        public Nullable<long> training_base_id { get; set; }
        public Nullable<long> semester_exam_period_id { get; set; }
        public string display_name { get; set; }
        public Nullable<System.DateTime> end_date { get; set; }
        public Nullable<System.DateTime> start_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam_course_subject> tbl_semester_subject_exam_course_subject { get; set; }
        public virtual tbl_training_base tbl_training_base { get; set; }
        public virtual tbl_semester_exam_period tbl_semester_exam_period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject> tbl_course_subject1 { get; set; }
        public virtual tbl_course_subject tbl_course_subject2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject> tbl_student_course_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_timetable_detail> tbl_timetable_detail { get; set; }
        public virtual tbl_semester_subject tbl_semester_subject { get; set; }
        public virtual tbl_staff tbl_staff { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_history> tbl_student_course_subject_history { get; set; }
        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }
        public virtual tbl_learning_skill tbl_learning_skill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_timetable> tbl_course_subject_timetable1 { get; set; }
    }
}