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
    
    public partial class tbl_education_program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_education_program()
        {
            this.tbl_course_subject_config = new HashSet<tbl_course_subject_config>();
            this.tbl_criteria_search_student = new HashSet<tbl_criteria_search_student>();
            this.tbl_student_education_program = new HashSet<tbl_student_education_program>();
            this.tbl_group_subject_program = new HashSet<tbl_group_subject_program>();
            this.tbl_student_graduate_conditional = new HashSet<tbl_student_graduate_conditional>();
            this.tbl_student_graduate = new HashSet<tbl_student_graduate>();
            this.tbl_knowledge_program = new HashSet<tbl_knowledge_program>();
            this.tbl_speciality_program = new HashSet<tbl_speciality_program>();
            this.tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            this.tbl_program_subject = new HashSet<tbl_program_subject>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<long> course_year_id { get; set; }
        public Nullable<long> education_level_id { get; set; }
        public Nullable<long> education_type_id { get; set; }
        public Nullable<long> speciality_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_course_subject_config> tbl_course_subject_config { get; set; }
        public virtual tbl_course_year tbl_course_year { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_criteria_search_student> tbl_criteria_search_student { get; set; }
        public virtual tbl_education_level tbl_education_level { get; set; }
        public virtual tbl_speciality tbl_speciality { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_education_program> tbl_student_education_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_group_subject_program> tbl_group_subject_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_graduate_conditional> tbl_student_graduate_conditional { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_graduate> tbl_student_graduate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_knowledge_program> tbl_knowledge_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_speciality_program> tbl_speciality_program { get; set; }
        public virtual tbl_education_type tbl_education_type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_program_subject> tbl_program_subject { get; set; }
    }
}
