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
    
    public partial class tbl_education_voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_education_voucher()
        {
            this.tbl_voucher_recieve_pay_able = new HashSet<tbl_voucher_recieve_pay_able>();
            this.tbl_education_voucher_detail = new HashSet<tbl_education_voucher_detail>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string code { get; set; }
        public Nullable<int> is_receive { get; set; }
        public string note { get; set; }
        public Nullable<int> payment_method { get; set; }
        public Nullable<int> status { get; set; }
        public Nullable<double> total_amount { get; set; }
        public Nullable<double> total_recived_amount { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<System.DateTime> voucher_date { get; set; }
        public Nullable<long> period_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<long> training_base_id { get; set; }
        public string number_book { get; set; }
        public Nullable<bool> view_able { get; set; }
        public string bank_import_code { get; set; }
    
        public virtual tbl_semester tbl_semester { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_voucher_recieve_pay_able> tbl_voucher_recieve_pay_able { get; set; }
        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_education_voucher_detail> tbl_education_voucher_detail { get; set; }
        public virtual tbl_training_base tbl_training_base { get; set; }
        public virtual tbl_student tbl_student { get; set; }
    }
}