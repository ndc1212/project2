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
    public partial class uClassroom : UserControl
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public uClassroom()
        {
            InitializeComponent();
            var result = db.tbl_room.Select(x => new
            {
                id = x.id,
                code = x.name,
                name = x.name,
                capacity = x.capacity,
                name_building = x.tbl_building.name,
                coso = x.tbl_building.tbl_training_base.name
            }).OrderBy(x=>x.coso).OrderBy(x=>x.name_building).OrderBy(x=>x.code).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("name");
            dt.Columns.Add("capacity");
            //dt.Columns.Add("code");
            dt.Columns.Add("name_building");
            dt.Columns.Add("coso");
            foreach (var item in result)
            {

                DataRow dr = dt.NewRow();
                dr["id"] = item.id;
                dr["name"] = item.name;
                dr["capacity"] = item.capacity;
                //dr["code"] = item.code;
                dr["name_building"] = item.name_building;
                dr["coso"] = item.coso;
                dt.Rows.Add(dr);

            }
            this.bindingSource = new BindingSource(dt, null);
            dgvClassroom.DataSource = this.bindingSource;
        }

        private void dgvClassroom_FilterStringChanged(object sender, EventArgs e)
        {
            
                 this.bindingSource.Sort = this.dgvClassroom.SortString;
        }

        private void dgvClassroom_SortStringChanged(object sender, EventArgs e)
        {
            this.bindingSource.Sort = this.dgvClassroom.SortString;
        }
    }
}
