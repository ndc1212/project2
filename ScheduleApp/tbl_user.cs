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
    
    public partial class tbl_user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_user()
        {
            this.tbl_organization_user = new HashSet<tbl_organization_user>();
            this.tbl_person = new HashSet<tbl_person>();
            this.tbl_student_candidate_profile = new HashSet<tbl_student_candidate_profile>();
            this.tbl_user_trainning_base = new HashSet<tbl_user_trainning_base>();
            this.tbl_role = new HashSet<tbl_role>();
            this.tbl_user_group = new HashSet<tbl_user_group>();
        }
    
        public long id { get; set; }
        public System.DateTime create_date { get; set; }
        public string created_by { get; set; }
        public string modified_by { get; set; }
        public Nullable<System.DateTime> modify_date { get; set; }
        public string uuid_key { get; set; }
        public Nullable<bool> voided { get; set; }
        public Nullable<bool> account_non_expired { get; set; }
        public Nullable<bool> account_non_locked { get; set; }
        public bool active { get; set; }
        public Nullable<bool> credentials_non_expired { get; set; }
        public string email { get; set; }
        public bool just_created { get; set; }
        public Nullable<long> last_login_failures { get; set; }
        public Nullable<System.DateTime> last_login_time { get; set; }
        public string password { get; set; }
        public Nullable<long> total_login_failures { get; set; }
        public string username { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_organization_user> tbl_organization_user { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_person> tbl_person { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_student_candidate_profile> tbl_student_candidate_profile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_trainning_base> tbl_user_trainning_base { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_role> tbl_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_user_group> tbl_user_group { get; set; }
    }
}