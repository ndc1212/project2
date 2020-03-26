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
    public partial class uGiangvien : UserControl
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        
        public uGiangvien()
        {
            InitializeComponent();
            //var result = db.tbl_person.Select(x => new
            //{
            //    id = x.id,
            //    first_name = x.first_name,
            //    last_name = x.last_name,
            //    gender = x.gender
            //}).OrderBy(x => x.id).ToList();
            var result = from a in db.tbl_staff
                         join b in db.tbl_person on a.id equals b.id                        
                         select new
                         {
                             id = a.id,
                             first_name = b.last_name,
                             last_name = b.first_name,
                             gender = b.gender,
                             bomon = a.tbl_position_staff.FirstOrDefault().tbl_department.name,
                             khoa = (from x in db.tbl_department where x.id == a.tbl_position_staff.FirstOrDefault().tbl_department.parent_id select x).FirstOrDefault().name,
                             sdt = b.phone_number,
                             email = b.email
                         }
                         ;


            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("first_name");
            dt.Columns.Add("last_name");
            dt.Columns.Add("gender");
            dt.Columns.Add("bomon");
            dt.Columns.Add("khoa");
            dt.Columns.Add("sdt");
            dt.Columns.Add("email");
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["id"] = item.id;
                dr["first_name"] = item.first_name;
                dr["last_name"] = item.last_name;
                dr["gender"] = item.gender;
                dr["bomon"] = item.bomon;
                dr["khoa"] = item.khoa;
                dr["sdt"] = item.sdt;
                dr["email"] = item.email;
                dt.Rows.Add(dr);

            }
            this.bindingSource = new BindingSource(dt, null);
            dgvGiangvien.DataSource = this.bindingSource;
        }

        private void dgvGiangvien_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvGiangvien.SortString;
        }

        private void dgvGiangvien_FilterStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Filter = this.dgvGiangvien.FilterString;
        }
    }
}
