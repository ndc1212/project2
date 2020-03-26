using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp.UserControls
{
    public partial class uLop : UserControl
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public uLop()
        {
            InitializeComponent();

            //var result = db.tbl_enrollment_class.ToList();

            var result = db.tbl_enrollment_class
                           .Select(x => new
                           {
                               className = x.className,
                               number_of_student = x.number_of_student,
                               nganhchinh = x.speciality_id,
                               vanbang2 = 2,
                               course_year_name = x.tbl_course_year.name,
                               speciality_name = x.tbl_speciality.name,
                               department_name = x.tbl_speciality.tbl_department.name, 
                               training_base_name = x.tbl_training_base.name,
                           }).OrderBy(x => x.course_year_name).OrderBy(x => x.speciality_name).OrderBy(x=> x.className);

            DataTable dt = new DataTable();
            dt.Columns.Add("className");
            
            dt.Columns.Add("number_of_student");
            //
            dt.Columns.Add("nganhchinh");
            dt.Columns.Add("vanbang2");
            //
            //dt.Columns.Add("schoolYear");
            dt.Columns.Add("course_year_name");
            //dt.Columns.Add("education_level_name");
            
            dt.Columns.Add("speciality_name");
            dt.Columns.Add("department_name");
            //dt.Columns.Add("speciality_numberic_code");
            dt.Columns.Add("training_base_name");
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["className"] = item.className;
                //
                dr["nganhchinh"] = item.nganhchinh;
                dr["vanbang2"] = item.vanbang2;
                //
                dr["department_name"] = item.department_name;
                dr["number_of_student"] = item.number_of_student;
                //dr["schoolYear"] = item.schoolYear;
                dr["course_year_name"] = item.course_year_name;
                //dr["education_level_name"] = item.tbl_education_level.name;
                dr["speciality_name"] = item.speciality_name;
                dr["training_base_name"] = item.training_base_name;
                //dr["speciality_numberic_code"] = item.speciality_numberic_code;

                dt.Rows.Add(dr);

            }
            this.bindingSource = new BindingSource(dt, null);
            dgvLop.DataSource = this.bindingSource;
            //
            dgvLop.Columns["nganhchinh"].HeaderText = "Ngành chính";
            dgvLop.Columns["vanbang2"].HeaderText = "Văn bằng 2";
            //
            dgvLop.Columns["className"].HeaderText = "Tên lớp";
            dgvLop.Columns["department_name"].HeaderText = "Tên khoa";
            dgvLop.Columns["number_of_student"].HeaderText = "Tổng Số SV";
            //dgvLop.Columns["schoolYear"].HeaderText = "Năm vào trường";
            
            dgvLop.Columns["speciality_name"].HeaderText = "Ngành";
            dgvLop.Columns["course_year_name"].HeaderText = "Khóa đào tạo";
            dgvLop.Columns["training_base_name"].HeaderText = "Cơ sở đào tạo";
        }

        private void dgvLop_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Filter = this.dgvLop.FilterString;
        }

        private void dgvLop_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvLop.SortString;
        }
    }
}
