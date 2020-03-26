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
    public partial class frmProgram : Form
    {
        public frmProgram()
        {
            InitializeComponent();
        }

        private void frmProgram_Load(object sender, EventArgs e)
        {
            getData();
        }

        public void getData()
        {
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = from programs in db.tbl_education_program
                         select new {
                             program_id                 = programs.id,
                             program_code               = programs.code,
                             program_name               = programs.name,
                             //course_year_id           = programs.course_year_id,
                             course_year                = programs.tbl_course_year.name,
                             speciality_name            = programs.tbl_speciality.name,
                             speciality_code            = programs.tbl_speciality.code,
                             speciality_numberic_code   = programs.tbl_speciality.numberic_code,
                             department_id              = programs.tbl_speciality.department_id,

                         };
            dgvPrograms.DataSource = result.ToList();
        }

        private void dgvPrograms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            long program_id = (long)dgvPrograms.Rows[e.RowIndex].Cells["program_id"].Value;
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = from program_subject in db.tbl_program_subject
                         where program_subject.program_id == program_id
                         select new {
                             program_id                 = program_subject.program_id,
                             subject_id                 = program_subject.subject_id,
                             subject_name               = program_subject.tbl_subject.subject_name,
                             semeter_index              = program_subject.semester_index,
                             //knowledge_program          = program_subject.tbl_knowledge_program.
                         };
            dgvSubjects.DataSource = result.ToList();
        }
    }
}
