using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ScheduleApp
{
    public partial class fDangnhap : Form
    {
        TLU_SAMSEntities db = new TLU_SAMSEntities();
        public static long UserID;
        public fDangnhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_UserName.Text == "" || txt_Password.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu");
                return;
            }
            try
            {
                //txt_Password.Text = "123456";
                var data = db.tbl_user.Where(x => x.username == txt_UserName.Text && txt_Password.Text == "123456").FirstOrDefault();
                
              
                if (data != null)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    this.Hide();
                    UserID = data.id;
                    fConfig fm = new fConfig();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
