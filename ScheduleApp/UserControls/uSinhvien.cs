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
    public partial class uSinhvien : UserControl
    {
        public uSinhvien()
        {
            InitializeComponent();
            getData();
        }
        public void getData()
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            //var result = from student in db.tbl_student_candidate_profile
            //             select new
            //             {
            //                 //student_id = student.id,
            //                 student_code = student.student_code,
            //                 full_name = student.last_name + " " + student.first_name,
            //                 //full_name = candidate.first_name + " " + candidate.last_name,
            //                 //class_id = student.class_id,
            //                 //class_code = student.tbl_student1.tbl_enrollment_class.classCode,
            //                 class_name = student.tbl_student1.tbl_enrollment_class.className,
            //                 //speciality_id                = student.tbl_enrollment_class.speciality_id,
            //                 speciality_name = student.tbl_student1.tbl_enrollment_class.tbl_speciality.name,
            //                 trainning_base = student.tbl_student1.tbl_enrollment_class.tbl_training_base.code,
            //                 khoadaotao = student.tbl_student1.tbl_enrollment_class.tbl_department.name,
            //                 khoahoc = student.tbl_student1.tbl_enrollment_class.tbl_course_year.name,
            //                 bacdaotao = student.tbl_course_year.tbl_education_level.name,
            //                 hedaotao = student.tbl_course_year.tbl_education_type.name,
            //                 chuongtrinhDT = student.tb

            //             };

            var result = from student in db.tbl_student_education_program
                         join candidate in db.tbl_student_candidate_profile on student.student_id equals candidate.student_id
                         select new
                         {
                             //student_id = student.id,
                             student_code = student.tbl_student.student_code,
                             full_name = candidate.last_name + " " + candidate.first_name,
                             //full_name = candidate.first_name + " " + candidate.last_name,
                             //class_id = student.class_id,
                             //class_code = student.tbl_student1.tbl_enrollment_class.classCode,
                             class_name = candidate.tbl_student1.tbl_enrollment_class.className,
                             //speciality_id                = student.tbl_enrollment_class.speciality_id,
                             speciality_name = candidate.tbl_student1.tbl_enrollment_class.tbl_speciality.name,
                             trainning_base = candidate.tbl_student1.tbl_enrollment_class.tbl_training_base.code,
                             khoadaotao = candidate.tbl_student1.tbl_enrollment_class.tbl_department.name,
                             khoahoc = candidate.tbl_student1.tbl_enrollment_class.tbl_course_year.name,
                             bacdaotao = candidate.tbl_course_year.tbl_education_level.name,
                             hedaotao = candidate.tbl_course_year.tbl_education_type.name,
                             chuongtrinhDT = student.tbl_education_program.name,
                             vanbang = student.tbl_student.tbl_student_certificate.FirstOrDefault().tbl_certificate.name
                         };
            DataTable dt = new DataTable();
            dt.Columns.Add("student_code");
            dt.Columns.Add("full_name");
            dt.Columns.Add("class_name");
            dt.Columns.Add("chuongtrinhDT");
            dt.Columns.Add("speciality_name");
            dt.Columns.Add("trainning_base");
            dt.Columns.Add("khoadaotao");
            dt.Columns.Add("bacdaotao");
            dt.Columns.Add("hedaotao");
            dt.Columns.Add("vanbang");
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["student_code"] = item.student_code;
                dr["full_name"] = item.full_name;
                dr["class_name"] = item.class_name;
                dr["chuongtrinhDT"] = item.chuongtrinhDT;
                dr["speciality_name"] = item.speciality_name;
                dr["trainning_base"] = item.trainning_base;
                dr["khoadaotao"] = item.khoadaotao;
                dr["bacdaotao"] = item.bacdaotao;
                dr["hedaotao"] = item.hedaotao;
                if(item.vanbang == null)
                    dr["vanbang"] = 1;
                dt.Rows.Add(dr);

            }
            this.bindingSource = new BindingSource(dt, null);
            dgvStudent.DataSource = this.bindingSource;
        }

        private void dgvStudent_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Filter = this.dgvStudent.FilterString;
        }

        private void dgvStudent_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvStudent.SortString;
        }
    }
}
