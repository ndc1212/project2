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
    
    public partial class tbl_subject_learning_skill
    {
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<bool> is_main_skill { get; set; }
        public Nullable<double> number_hour { get; set; }
        public Nullable<long> learning_skill_id { get; set; }
        public Nullable<long> subject_id { get; set; }
    
        public virtual tbl_learning_skill tbl_learning_skill { get; set; }
        public virtual tbl_subject tbl_subject { get; set; }
    }
}
