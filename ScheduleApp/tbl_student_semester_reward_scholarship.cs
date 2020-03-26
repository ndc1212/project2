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
    
    public partial class tbl_student_semester_reward_scholarship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_semester_reward_scholarship()
        {
            this.tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
            this.tbl_student_scholarship_history = new HashSet<tbl_student_scholarship_history>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<double> behavior_mark { get; set; }
        public string behavior_mark_char { get; set; }
        public Nullable<System.DateTime> date_forward { get; set; }
        public Nullable<double> first_amount { get; set; }
        public Nullable<bool> is_forward { get; set; }
        public Nullable<bool> is_lock { get; set; }
        public Nullable<double> last_amount { get; set; }
        public Nullable<int> level { get; set; }
        public Nullable<double> mark { get; set; }
        public Nullable<double> mark4 { get; set; }
        public Nullable<double> mark4_advanced { get; set; }
        public Nullable<double> mark_advanced { get; set; }
        public Nullable<int> number_of_credit { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<double> tuition_balance { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<long> receive_pay_able_id { get; set; }
        public Nullable<long> scholarship_condition_id { get; set; }
        public Nullable<long> scholarship_fund_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
    
        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }
        public virtual tbl_scholarship_condition tbl_scholarship_condition { get; set; }
        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_student tbl_student { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_scholarship_history> tbl_student_scholarship_history { get; set; }
    }
}