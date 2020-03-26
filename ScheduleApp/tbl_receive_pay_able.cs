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
    
    public partial class tbl_receive_pay_able
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_receive_pay_able()
        {
            this.tbl_education_voucher_detail = new HashSet<tbl_education_voucher_detail>();
            this.tbl_student_semester_reward_scholarship = new HashSet<tbl_student_semester_reward_scholarship>();
            this.tbl_student_tuition_fee_calculate = new HashSet<tbl_student_tuition_fee_calculate>();
            this.tbl_student_scholarship_history = new HashSet<tbl_student_scholarship_history>();
            this.tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            this.tbl_receive_pay_able1 = new HashSet<tbl_receive_pay_able>();
            this.tbl_student_course_subject_cancel_fee = new HashSet<tbl_student_course_subject_cancel_fee>();
            this.tbl_voucher_recieve_pay_able = new HashSet<tbl_voucher_recieve_pay_able>();
            this.tbl_voucher_detail_recieve_pay_able_link = new HashSet<tbl_voucher_detail_recieve_pay_able_link>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<double> amount_after_balance { get; set; }
        public Nullable<double> amount_done { get; set; }
        public Nullable<double> amount_received { get; set; }
        public Nullable<bool> is_complete { get; set; }
        public Nullable<int> is_receive { get; set; }
        public string note { get; set; }
        public Nullable<System.DateTime> receivable_date { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<double> transfer_value { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<double> withdrawal_value { get; set; }
        public Nullable<long> adjusted_receive_pay_able_id { get; set; }
        public Nullable<long> register_period_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<System.DateTime> last_pay_date { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }
        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_semester_reward_scholarship> tbl_student_semester_reward_scholarship { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_tuition_fee_calculate> tbl_student_tuition_fee_calculate { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able> tbl_receive_pay_able1 { get; set; }
        public virtual tbl_receive_pay_able tbl_receive_pay_able2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_course_subject_cancel_fee> tbl_student_course_subject_cancel_fee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_recieve_pay_able> tbl_voucher_recieve_pay_able { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_detail_recieve_pay_able_link> tbl_voucher_detail_recieve_pay_able_link { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_student tbl_student { get; set; }
    }
}