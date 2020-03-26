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
    public partial class uUsers : UserControl
    {
        public uUsers()
        {
            InitializeComponent();
            TLU_SAMSEntities db = new TLU_SAMSEntities();
            var result = db.tbl_user.Select( x => new
            {
                id = x.id,
                username = x.username,
                password = x.password,
                email = x.email,
                active = x.active
            }).ToList();
            dgvUser.DataSource = result.ToList();
        }
    }
}
