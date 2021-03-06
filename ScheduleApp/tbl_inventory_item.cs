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
    
    public partial class tbl_inventory_item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_inventory_item()
        {
            this.tbl_inventory_item1 = new HashSet<tbl_inventory_item>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public double amount { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public Nullable<int> is_receive { get; set; }
        public int kind { get; set; }
        public string note { get; set; }
        public Nullable<int> payment_method { get; set; }
        public int type { get; set; }
        public Nullable<long> education_voucher_detail_id { get; set; }
        public Nullable<long> fee_item_id { get; set; }
        public Nullable<long> fee_item_detail_id { get; set; }
        public Nullable<long> inventory_item_id { get; set; }
        public Nullable<long> period_id { get; set; }
        public Nullable<long> receive_pay_able_detail_id { get; set; }
        public Nullable<long> scholarship_fund_id { get; set; }
        public Nullable<long> semester_id { get; set; }
        public Nullable<long> student_id { get; set; }
        public Nullable<long> student_expectation_register_id { get; set; }
        public Nullable<long> student_scholarship_history_id { get; set; }
        public Nullable<long> student_tuition_fee_calculate_id { get; set; }
    
        public virtual tbl_education_voucher_detail tbl_education_voucher_detail { get; set; }
        public virtual tbl_fee_item tbl_fee_item { get; set; }
        public virtual tbl_fee_item_detail tbl_fee_item_detail { get; set; }
        public virtual tbl_student_tuition_fee_calculate tbl_student_tuition_fee_calculate { get; set; }
        public virtual tbl_student tbl_student { get; set; }
        public virtual tbl_receive_pay_able_detail tbl_receive_pay_able_detail { get; set; }
        public virtual tbl_student_scholarship_history tbl_student_scholarship_history { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item1 { get; set; }
        public virtual tbl_inventory_item tbl_inventory_item2 { get; set; }
        public virtual tbl_scholarship_fund tbl_scholarship_fund { get; set; }
        public virtual tbl_semester tbl_semester { get; set; }
        public virtual tbl_student_expectation_register tbl_student_expectation_register { get; set; }
        public virtual tbl_semester_register_period tbl_semester_register_period { get; set; }
    }
}
