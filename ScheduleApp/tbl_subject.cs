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
    
    public partial class tbl_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_subject()
        {
            this.tbl_criteria_search_student_except_subject = new HashSet<tbl_criteria_search_student_except_subject>();
            this.tbl_equivalent_subject = new HashSet<tbl_equivalent_subject>();
            this.tbl_expectation_register = new HashSet<tbl_expectation_register>();
            this.tbl_prerequisite_subject = new HashSet<tbl_prerequisite_subject>();
            this.tbl_program_subject = new HashSet<tbl_program_subject>();
            this.tbl_semester_subject = new HashSet<tbl_semester_subject>();
            this.tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
            this.tbl_student_mark = new HashSet<tbl_student_mark>();
            this.tbl_student_subject_mark = new HashSet<tbl_student_subject_mark>();
            this.tbl_subject_education_level_type = new HashSet<tbl_subject_education_level_type>();
            this.tbl_subject_exam = new HashSet<tbl_subject_exam>();
            this.tbl_subject_learning_skill = new HashSet<tbl_subject_learning_skill>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<int> examTime { get; set; }
        public Nullable<bool> is_calculate_mark { get; set; }
        public Nullable<bool> is_currently_using { get; set; }
        public Nullable<int> number_of_credit { get; set; }
        public string subject_code { get; set; }
        public string subject_name { get; set; }
        public string subject_name_eng { get; set; }
        public Nullable<int> subject_type { get; set; }
        public Nullable<long> department_id { get; set; }
        public Nullable<long> exam_skill_id { get; set; }
        public string define_code { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_criteria_search_student_except_subject> tbl_criteria_search_student_except_subject { get; set; }
        public virtual tbl_department tbl_department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_equivalent_subject> tbl_equivalent_subject { get; set; }
        public virtual tbl_exam_skill tbl_exam_skill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_prerequisite_subject> tbl_prerequisite_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject> tbl_program_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_mark> tbl_student_mark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_subject_mark> tbl_student_subject_mark { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_education_level_type> tbl_subject_education_level_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_learning_skill> tbl_subject_learning_skill { get; set; }
    }
}