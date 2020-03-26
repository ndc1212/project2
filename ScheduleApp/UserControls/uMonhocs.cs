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

    public partial class uMonhocs : UserControl
    {
        Common _common = new Common();
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public uMonhocs()
        {
            InitializeComponent();
            getSubject_available();
        }
        public void getSubject_available()
        {

            var result = db.tbl_subject
                            .Where(x => x.tbl_program_subject.Count(y => y.semester_index != null && y.semester_index > 0) > 0
                            )
                            .Select(x => new
                            {
                                subject_id = x.id,
                                subject_code = x.subject_code,
                                subject_name = x.subject_name,
                                department_name = x.tbl_department.name,
                                number_of_credit = x.number_of_credit,
                                subject_type = x.tbl_subject_learning_skill.ToList(),
                            }).OrderBy(x => x.department_name).OrderBy(x=>x.subject_name);

            int numCol = 9;

            DataTable dt = new DataTable();
            dt.Columns.Add("subject_code");
            dt.Columns.Add("subject_name");
            dt.Columns.Add("department_name");
            dt.Columns.Add("number_of_credit");
  
            dt.Columns.Add("a");
            dt.Columns.Add("b");
            dt.Columns.Add("c");
            dt.Columns.Add("d");
            var skill = db.tbl_learning_skill.ToList();
            for (int i = 0; i < db.tbl_learning_skill.Count(); i++)
            { 
                dt.Columns.Add(skill[i].code);
            }
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["subject_code"] = item.subject_code;
                dr["subject_name"] = item.subject_name;
                dr["department_name"] = item.department_name;
                dr["number_of_credit"] = item.number_of_credit;
                dr["a"] = null;
                dr["b"] = null;
                dr["c"] = null;
                dr["d"] = null;
                for (int i = 0; i < item.subject_type.Count(); i++)
                {

                    dr[item.subject_type[i].tbl_learning_skill.code] = item.subject_type[i].number_hour;
                   
                }
                dt.Rows.Add(dr);
               
            }
            this.bindingSource = new BindingSource(dt, null);
            dgvSubject.DataSource = this.bindingSource;

            for (int i = 0; i < db.tbl_learning_skill.Count(); i++)
            {
                dgvSubject.Columns[i + numCol].HeaderText = skill[i].name;
                dgvSubject.Columns[i + numCol].Width = 50;
            }

        }

        private void cbKhoahoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbHedaotao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var result = db.tbl_subject
            //                .Where(x => x.tbl_program_subject.Count(y => y.semester_index != null && y.semester_index > 0) > 0
            //                && x.department_id == Convert.ToInt64(cbHedaotao.SelectedValue.ToString())
            //                )
            //                .Select(x => new {
            //                    //id = x.id,
            //                    subject_code = x.subject_code,
            //                    subject_name = x.subject_name,
            //                    department_id = x.department_id,
            //                    department_name = x.tbl_department.name

            //                }).OrderBy(x => x.department_id);
            //dgvSubject.DataSource = result.ToList();
        }

        private void cbBomon_SelectedIndexChanged(object sender, EventArgs e)
        {
            //long selected = Convert.ToInt64(cbBomon.SelectedValue.ToString());
            //var result = db.tbl_subject
            //               .Where(x => x.tbl_program_subject.Count(y => y.semester_index != null && y.semester_index > 0) > 0
            //               && x.department_id == selected
            //               )
            //               .Select(x => new {
            //                    //id = x.id,
            //                    subject_code = x.subject_code,
            //                   subject_name = x.subject_name,
            //                   department_id = x.department_id,
            //                   department_name = x.tbl_department.name

            //               }).OrderBy(x => x.department_id);
            //dgvSubject.DataSource = result.ToList();
        }

        private void dgvSubject_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Filter = this.dgvSubject.FilterString;
        }

        private void dgvSubject_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvSubject.SortString;
        }
    }
}
