using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = from student in db.tbl_student
                         join candidate in db.tbl_student_candidate_profile on student.student_code equals candidate.student_code
                         select new {
                             student_id                     = student.id,
                             student_code                   = student.student_code,
                             full_name                      = candidate.first_name + " " + candidate.last_name,
                             class_id                       = student.class_id,
                             class_code                     = student.tbl_enrollment_class.classCode,
                             class_name                     = student.tbl_enrollment_class.className,
                             //speciality_id                = student.tbl_enrollment_class.speciality_id,
                             speciality_name                = student.tbl_enrollment_class.tbl_speciality.name,
                             trainning_base                 = student.tbl_enrollment_class.tbl_training_base.code,
                        };
            dgvStudent.DataSource = result.ToList();
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long student_id = (long)dgvStudent.Rows[e.RowIndex].Cells["student_id"].Value;

            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = from course in db.tbl_student_course_subject
                         where course.student_id == student_id
                         select new {
                             course_subject_id              = course.course_subject_id,
                             course_subject_code            = course.tbl_course_subject.code,
                             course_subject_shortcode       = course.tbl_course_subject.code,
                             semeter_subject_id             = course.tbl_course_subject.semester_subject_id,
                             min_students                   = course.tbl_course_subject.min_student,
                             max_students                   = course.tbl_course_subject.max_student,
                             number_students                = course.tbl_course_subject.numberStudent,
                             number_course                  = course.tbl_course_subject.tbl_semester_subject.number_course,
                             trainning_base_name            = course.tbl_course_subject.tbl_training_base.code
                         };
            dgvCourse.DataSource = result.ToList();

            var program = from student_program in db.tbl_student_education_program
                          where student_program.student_id == student_id
                          select new {
                              education_program_id          = student_program.education_program_id,
                              is_main                       = student_program.is_main,
                              education_program_name        = student_program.tbl_education_program.name,
                              education_program_code        = student_program.tbl_education_program.code
                          };
            dgvProgram.DataSource = program.ToList();

        }
    }
}
