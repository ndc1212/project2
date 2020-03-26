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
    
    public partial class tbl_program_subject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_program_subject()
        {
            this.tbl_equivalent_subject = new HashSet<tbl_equivalent_subject>();
            this.tbl_prerequisite_subject = new HashSet<tbl_prerequisite_subject>();
            this.tbl_subject_exam = new HashSet<tbl_subject_exam>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<int> mark { get; set; }
        public Nullable<int> semester { get; set; }
        public Nullable<int> semester_index { get; set; }
        public Nullable<int> subject_type { get; set; }
        public Nullable<long> group_id { get; set; }
        public Nullable<long> knowledge_program_id { get; set; }
        public Nullable<long> program_id { get; set; }
        public Nullable<long> subject_id { get; set; }
        public Nullable<double> tuition_coefficient { get; set; }
    
        public virtual tbl_education_program tbl_education_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_equivalent_subject> tbl_equivalent_subject { get; set; }
        public virtual tbl_group_subject_program tbl_group_subject_program { get; set; }
        public virtual tbl_knowledge_program tbl_knowledge_program { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_prerequisite_subject> tbl_prerequisite_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_subject_exam> tbl_subject_exam { get; set; }
        public virtual tbl_subject tbl_subject { get; set; }
    }
}
