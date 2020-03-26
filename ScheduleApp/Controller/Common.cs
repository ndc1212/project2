using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;



namespace ScheduleApp.Controller
{
   
    class Common
    {
        private ScheduleApp.TLU_SAMSEntities db = new TLU_SAMSEntities();
        public void setComboData<T>(ComboBox cb, string displayValue, string nameValue, List<T> list, EventHandler eventText)
        {
            cb.SelectedIndexChanged -= eventText;
            cb.DataSource = list;
            cb.DisplayMember = displayValue;
            cb.ValueMember = nameValue;
            cb.SelectedIndex = 0;
            cb.SelectedIndexChanged += eventText;
        }    
        //public List<a> getGiangVien()
        //{
        //    var result = from a in db.tbl_staff
        //                 join b in db.tbl_person on a.id equals b.id
        //                 select new
        //                 {
        //                     id = a.id,
        //                     first_name = b.last_name,
        //                     last_name = b.first_name,
        //                     gender = b.gender
        //                 };
        //    return result;
        //}
    }
}
