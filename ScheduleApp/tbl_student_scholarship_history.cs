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
    
    public partial class tbl_student_scholarship_history
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_student_scholarship_history()
        {
            this.tbl_inventory_item = new HashSet<tbl_inventory_item>();
            this.tbl_receive_pay_able_detail = new HashSet<tbl_receive_pay_able_detail>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<double> amountBefore { get; set; }
        public Nullable<System.DateTime> dateModify { get; set; }
        public string userModify { get; set; }
        public Nullable<long> receive_pay_able_id { get; set; }
        public Nullable<long> student_semester_scholarship_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_inventory_item> tbl_inventory_item { get; set; }
        public virtual tbl_receive_pay_able tbl_receive_pay_able { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_receive_pay_able_detail> tbl_receive_pay_able_detail { get; set; }
        public virtual tbl_student_semester_reward_scholarship tbl_student_semester_reward_scholarship { get; set; }
    }
}
