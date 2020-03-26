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
    
    public partial class tbl_school_fee_config
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_school_fee_config()
        {
            this.tbl_fee_config_item = new HashSet<tbl_fee_config_item>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public string code { get; set; }
        public Nullable<System.DateTime> from_date { get; set; }
        public Nullable<bool> is_current { get; set; }
        public string name { get; set; }
        public Nullable<System.DateTime> to_date { get; set; }
        public Nullable<long> course_year_id { get; set; }
        public Nullable<long> sepeciality_id { get; set; }
        public Nullable<long> student_object_id { get; set; }
        public Nullable<long> training_base_id { get; set; }
        public Nullable<long> department_id { get; set; }
    
        public virtual tbl_course_year tbl_course_year { get; set; }
        public virtual tbl_department tbl_department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_fee_config_item> tbl_fee_config_item { get; set; }
        public virtual tbl_student_object tbl_student_object { get; set; }
        public virtual tbl_training_base tbl_training_base { get; set; }
        public virtual tbl_speciality tbl_speciality { get; set; }
    }
}