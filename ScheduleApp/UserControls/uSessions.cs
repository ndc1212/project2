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
    public partial class uSessions : UserControl
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public uSessions()
        {
            InitializeComponent();
            var result = db.tbl_1config.ToList();
            dgvSession.DataSource = result.ToList();
        }
    }
}
