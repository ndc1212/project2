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
    public partial class fMonHoc : Form
    {
        public fMonHoc()
        {
            InitializeComponent();
        }
        int ky = 2;
        int nam = 2019;
        private void fMonHoc_Load(object sender, EventArgs e)
        {
            lbName.Text = ky + " năm học " + nam + " - " + (nam + 1);
            getSubject_available();
        }

        
        public void getSubject_available()
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = db.tbl_subject
                            .Where(x => 
                                x.tbl_program_subject.Count(y => y.semester_index != null && y.semester_index > 0 && y.semester_index % 2 == (ky % 2) && (y.tbl_education_program.tbl_course_year.year + (int)(y.semester_index-1)/2) == nam) > 0

                            )
                            .Select(x => new {
                                id                      = x.id,
                                subject_code            = x.subject_code,
                                subject_name            = x.subject_name,
                                //subject_name_eng        = x.subject_name_eng,
                                //subject_type            = x.subject_type,
                                department_id           = x.department_id,
                                department_name         = x.tbl_department.name

                            }).OrderBy(x => x.department_id);

            lb_subjects.Text = result.Count() + " môn";
            dgvSubject.DataSource = result.ToList();
        }



        public void getProgram_hasSubject(long id_subject)
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = db.tbl_program_subject
                            .Where(x => x.subject_id == id_subject && x.semester_index != null && x.semester_index > 0 && x.semester_index % 2 == (ky%2) && (x.tbl_education_program.tbl_course_year.year + (int)(x.semester_index-1) / 2) == nam)
                            .Select(x => new
                            {
                                id                  = x.id,
                                program_id          = x.program_id,
                                program_name        = x.tbl_education_program.name,
                                semester_index      = x.semester_index,
                                //subject_type        = x.subject_type,
                                knowledge_program   = x.knowledge_program_id,
                                number_student      = x.tbl_education_program.tbl_student_education_program.Count()
                            });

            dgvPrograms.DataSource = result.ToList();
            dgvPrograms.Tag = id_subject;
        }

        public void getStudent_hasSubject(long id_education_program)
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = db.tbl_student_education_program
                            .Where(x => x.education_program_id == id_education_program)
                            .Select(x => new
                            {
                                id              = x.id,
                                student_id      = x.student_id,
                                is_main         = x.is_main,
                                class_id        = x.tbl_student.class_id,
                                class_name      = x.tbl_student.tbl_enrollment_class.className
                            })
                            .OrderBy(x => x.class_id);
            dgvClasses.DataSource = result.ToList();
        }

        private void dgvSubject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long id_subject = (long)dgvSubject.Rows[e.RowIndex].Cells["id"].Value;
            getProgram_hasSubject(id_subject);
        }

        private void dgvPrograms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long id_education_program = (long)dgvPrograms.Rows[e.RowIndex].Cells["program_id"].Value;
            getStudent_hasSubject(id_education_program);
        }
    }
}
