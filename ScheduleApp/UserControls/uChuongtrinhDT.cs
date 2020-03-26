using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApp.Controller;
namespace ScheduleApp.UserControls
{
    public partial class uChuongtrinhDT : UserControl
    {
        Common _common = new Common();
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public uChuongtrinhDT()
        {
            InitializeComponent();

            //var result = from programs in db.tbl_education_program
            //             select new
            //             {
            //                 program_id = programs.id,
            //                 program_code = programs.code, // ten lop
            //                 //so lop             
            //                 program_solop = (from x in db.tbl_enrollment_class where x.speciality_id == programs.speciality_id && x.create_date.Year == programs.create_date.Year select x.id).Count(),

            //                 //tong so sv
            //                 program_tsv = (from x in db.tbl_enrollment_class where x.speciality_id == programs.speciality_id && x.create_date.Year == programs.create_date.Year select x.number_of_student).Sum(),

            //                 //
            //                 program_name = programs.name, // ten chuong trinh dao tao
            //                 //course_year_id           = programs.course_year_id,
            //                 course_year = programs.tbl_course_year.name, //khoa'
            //                 speciality_name = programs.tbl_speciality.name, //nganh
            //                 speciality_code = programs.tbl_speciality.code,
            //                 speciality_numberic_code = programs.tbl_speciality.numberic_code,
            //                 department_name = programs.tbl_speciality.tbl_department.name,// khoa

            //             };
            var result = db.tbl_education_program                           
                            .Select(x => new
                            {
                                program_id = x.id,
                                program_code = x.code, // ten lop
                                program_solop = (from y in db.tbl_enrollment_class where y.speciality_id == x.speciality_id && y.create_date.Year == x.create_date.Year select y.id).Count(),
                                program_tsv = (from y in db.tbl_enrollment_class where y.speciality_id == x.speciality_id && y.create_date.Year == x.create_date.Year select y.number_of_student).Sum(),
                                program_name = x.name, //ten ct dao tao
                                course_year = x.tbl_course_year.name, //khoa'
                                speciality_name = x.tbl_speciality.name, //nganh
                                department_name = x.tbl_speciality.tbl_department.name, // khoa
                            }).OrderBy(x => x.course_year).OrderBy(x => x.speciality_name).OrderBy(x=>x.program_code);


            DataTable dt = new DataTable();
            dt.Columns.Add("program_code");
            //
            dt.Columns.Add("program_solop");
            dt.Columns.Add("program_tsv");
            //
            dt.Columns.Add("program_name");
            dt.Columns.Add("course_year");
            dt.Columns.Add("speciality_name");
            //dt.Columns.Add("speciality_numberic_code");
            dt.Columns.Add("department_name");
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["program_code"] = item.program_code;
                //
                dr["program_solop"] = item.program_solop;
                dr["program_tsv"] = item.program_tsv;
                //
                dr["program_name"] = item.program_name;
                dr["department_name"] = item.department_name;
                dr["course_year"] = item.course_year;
                dr["speciality_name"] = item.speciality_name;
                //dr["speciality_numberic_code"] = item.speciality_numberic_code;
               
                dt.Rows.Add(dr);

            }
            this.bindingSource = new BindingSource(dt, null);
            dgvChuongtrinhDT.DataSource = this.bindingSource;
            dgvChuongtrinhDT.Columns["program_code"].HeaderText = "Tên lớp";
            //
            dgvChuongtrinhDT.Columns["program_solop"].HeaderText = "Số lớp";
            dgvChuongtrinhDT.Columns["program_tsv"].HeaderText = "Tổng sinh viên";
            //
            dgvChuongtrinhDT.Columns["department_name"].HeaderText = "Tên khoa";
            dgvChuongtrinhDT.Columns["program_name"].HeaderText = "Tên chương trình ĐT";
            dgvChuongtrinhDT.Columns["course_year"].HeaderText = "Khóa đào tạo";
            dgvChuongtrinhDT.Columns["speciality_name"].HeaderText = "Ngành";
        }

        private void dgvChuongtrinhDT_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Filter = this.dgvChuongtrinhDT.FilterString;
        }

        private void dgvChuongtrinhDT_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvChuongtrinhDT.SortString;
        }
    }
}
