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
    
    public partial class tbl_scholarship_condition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_scholarship_condition()
        {
            this.tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<double> behaviour_mark { get; set; }
        public string behaviour_mark_compare { get; set; }
        public Nullable<double> certificate_mark10 { get; set; }
        public Nullable<double> certificate_mark4 { get; set; }
        public Nullable<double> certificate_mark_char { get; set; }
        public string certificate_mark_compare { get; set; }
        public Nullable<bool> check_full_school_year_mark { get; set; }
        public Nullable<bool> check_full_year_certificate_mark { get; set; }
        public Nullable<bool> check_full_year_min_mark { get; set; }
        public Nullable<bool> check_full_year_number_subject_failed { get; set; }
        public Nullable<bool> check_pre_year_mark { get; set; }
        public Nullable<bool> check_subject_not_counted { get; set; }
        public Nullable<bool> check_subject_not_counted_min_mark { get; set; }
        public Nullable<bool> check_subject_not_mark { get; set; }
        public Nullable<bool> check_subject_not_mark_register { get; set; }
        public Nullable<bool> check_time { get; set; }
        public Nullable<bool> check_year_mark { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<double> mark10 { get; set; }
        public Nullable<double> mark4 { get; set; }
        public Nullable<double> mark_char { get; set; }
        public string mark_compare { get; set; }
        public Nullable<double> mark_extend { get; set; }
        public string mark_extend_compare { get; set; }
        public Nullable<double> min_mark10 { get; set; }
        public Nullable<double> min_mark4 { get; set; }
        public Nullable<double> min_mark_char { get; set; }
        public string min_mark_compare { get; set; }
        public Nullable<int> number_credit_pre_semester { get; set; }
        public string number_credit_pre_semester_compare { get; set; }
        public Nullable<int> number_credit_register { get; set; }
        public string number_credit_register_compare { get; set; }
        public Nullable<int> number_credit_semester { get; set; }
        public string number_credit_semester_compare { get; set; }
        public Nullable<int> number_credit_to_semester { get; set; }
        public string number_credit_to_semester_compare { get; set; }
        public Nullable<int> number_subject_failed { get; set; }
        public string number_subject_failed_compare { get; set; }
        public Nullable<int> number_subject_not_exam { get; set; }
        public string number_subject_not_exam_compare { get; set; }
        public string student_object_compare { get; set; }
        public string student_object_semester_compare { get; set; }
        public Nullable<long> course_year_id { get; set; }
        public Nullable<long> discipline_id { get; set; }
        public Nullable<long> class_id { get; set; }
        public Nullable<long> scholarship_fund_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> speciality_id { get; set; }
        public Nullable<long> student_object_id { get; set; }
        public Nullable<long> student_object_semester_id { get; set; }
    
        public virtual tbl_course_year tbl_course_year { get; set; }
        public virtual tbl_discipline tbl_discipline { get; set; }
        public virtual tbl_enrollment_class tbl_enrollment_class { get; set; }
        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }
        public virtual tbl_student_object tbl_student_object { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_speciality tbl_speciality { get; set; }
        public virtual tbl_student_object tbl_student_object1 { get; set; }
    }
}
