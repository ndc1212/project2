using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Windows.Controls;

namespace ScheduleApp
{
    public partial class fConfig : Form
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public fConfig()
        {
           
            InitializeComponent();
            Dictionary<string, string> dNamhoc = new Dictionary<string, string>();
            dNamhoc.Add("_20192020", "2019-2020");
            dNamhoc.Add("_20202021", "2020-2021");


            cbNamhoc.DataSource = new BindingSource(dNamhoc, null);
            cbNamhoc.DisplayMember = "Value";
            cbNamhoc.ValueMember = "Key";

            Dictionary<string, string> dHocky = new Dictionary<string, string>();
            dHocky.Add("_1", "Học kỳ I");
            dHocky.Add("_2", "Học kỳ II");
            dHocky.Add("_3", "Học kỳ hè");


            cbHocky.DataSource = new BindingSource(dHocky, null);
            cbHocky.DisplayMember = "Value";
            cbHocky.ValueMember = "Key";


            long id = fDangnhap.UserID;
            var username = db.tbl_user.Where(x => x.id == id).FirstOrDefault().username;
            var list = db.tbl_1config.Where(x=>x.created_user == username).ToList();
            tbl_1config first = new tbl_1config();
            first.Id = -1;
            first.session = "Lựa chọn";
            
            list.Insert(0, first);
            cbPhienConfig.SelectedIndexChanged -= cbPhienConfig_SelectedIndexChanged;

            cbPhienConfig.DataSource = list;
            cbPhienConfig.DisplayMember = "session";
            cbPhienConfig.ValueMember = "Id";
            cbPhienConfig.SelectedIndex = 0;

            cbPhienConfig.SelectedIndexChanged += cbPhienConfig_SelectedIndexChanged;
           

        }

        private void btnLoaddata_Click(object sender, EventArgs e)
        {
            var selected = cbPhienConfig.SelectedValue.ToString();
            if (selected == "-1")
            {
                tbl_1config data = new tbl_1config();
                data.Namhoc = cbNamhoc.SelectedValue.ToString();
                data.Kyhoc = cbHocky.SelectedValue.ToString();
                data.created_date = DateTime.Now;
                long id = fDangnhap.UserID;
                var username = db.tbl_user.Where(x => x.id == id).FirstOrDefault().username;
                data.created_user = username;
                data.last_visited = DateTime.Now;
                data.session = data.created_user + data.Namhoc + data.Kyhoc + data.created_date.Value.Year + data.created_date.Value.Month + data.created_date.Value.Day + data.created_date.Value.Hour + data.created_date.Value.Minute + data.created_date.Value.Second + data.created_date.Value.Millisecond;
                db.tbl_1config.Add(data);
                db.SaveChanges();
            }
            else
            {
                int ma = Convert.ToInt32(selected);
                var last_visited = db.tbl_1config.Where(x => x.Id == ma).FirstOrDefault();
                last_visited.last_visited = DateTime.Now;
                db.Entry(last_visited).State = EntityState.Modified;
                db.SaveChanges();

            }           
        }

        private void cbPhienConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = cbPhienConfig.SelectedValue.ToString();
            if (selected == "-1")
            {
                cbHocky.Enabled = true;
                cbNamhoc.Enabled = true;
            }
            else
            {
                cbHocky.Enabled = false;
                cbNamhoc.Enabled = false;
            }
        }

      
    }
}
