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
    
    public partial class tbl_student_other_fee
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string class_name { get; set; }
        public string code { get; set; }
        public Nullable<double> credit_amount { get; set; }
        public Nullable<double> debit_amount { get; set; }
        public string note { get; set; }
        public Nullable<int> order_number { get; set; }
        public Nullable<double> return_amount { get; set; }
        public string student_code { get; set; }
        public Nullable<long> student_id { get; set; }
        public string student_name { get; set; }
        public Nullable<System.DateTime> voucher_date { get; set; }
        public Nullable<int> voucher_type { get; set; }
        public Nullable<double> additional { get; set; }
        public string semester_code { get; set; }
        public Nullable<long> semester_id { get; set; }
        public string training_base_code { get; set; }
        public Nullable<long> training_base_id { get; set; }
        public string training_base_name { get; set; }
    }
}
