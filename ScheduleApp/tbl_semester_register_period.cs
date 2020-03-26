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
    
    public partial class tbl_semester_register_period
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_semester_register_period()
        {
            this.tbl_education_program_tuition_fee = new HashSet<tbl_education_program_tuition_fee>();
            this.tbl_education_voucher = new HashSet<tbl_education_voucher>();
            this.tbl_exam_register_period = new HashSet<tbl_exam_register_period>();
            this.tbl_expectation_register = new HashSet<tbl_expectation_register>();
            this.tbl_inventory_item = new HashSet<tbl_inventory_item>();
            this.tbl_receive_pay_able = new HashSet<tbl_receive_pay_able>();
            this.tbl_register_period_time_config = new HashSet<tbl_register_period_time_config>();
            this.tbl_semester_exam_period = new HashSet<tbl_semester_exam_period>();
            this.tbl_semester_subject = new HashSet<tbl_semester_subject>();
            this.tbl_student_register_change = new HashSet<tbl_student_register_change>();
            this.tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            this.tbl_student_course_subject_edited = new HashSet<tbl_student_course_subject_edited>();
            this.tbl_semester_subject_exam = new HashSet<tbl_semester_subject_exam>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<int> display_order { get; set; }
        public Nullable<System.DateTime> end_register_time { get; set; }
        public Nullable<System.DateTime> end_unregister_time { get; set; }
        public Nullable<bool> is_lock_register { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> start_register_time { get; set; }
        public Nullable<long> semeter_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_program_tuition_fee> tbl_education_program_tuition_fee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher> tbl_education_voucher { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_exam_register_period> tbl_exam_register_period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_expectation_register> tbl_expectation_register { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_register_period_time_config> tbl_register_period_time_config { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_exam_period> tbl_semester_exam_period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject> tbl_semester_subject { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_register_change> tbl_student_register_change { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_edited> tbl_student_course_subject_edited { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_semester_subject_exam> tbl_semester_subject_exam { get; set; }
    }
}
