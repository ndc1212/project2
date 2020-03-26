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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnCTDT_Click(object sender, EventArgs e)
        {
            UserControls.uChuongtrinhDT uc = new UserControls.uChuongtrinhDT();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();

            pnMain.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
            uc.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserControls.uUsers uc = new UserControls.uUsers();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnPhien_Click(object sender, EventArgs e)
        {
            UserControls.uSessions uc = new UserControls.uSessions();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnKhoaHoc_Click(object sender, EventArgs e)
        {
            //UserControls.uKhoahocs uc = new UserControls.uKhoahocs();
            //if (!pnMain.Controls.Contains(uc))
            //{
            //    pnMain.Controls.Add(uc);
            //    uc.Dock = DockStyle.Fill;
            //    uc.BringToFront();
            //}
            //else
            //    uc.BringToFront();
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            UserControls.uClassroom uc = new UserControls.uClassroom();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

            UserControls.uSinhvien uc = new UserControls.uSinhvien();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            UserControls.uGiangvien uc = new UserControls.uGiangvien();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            UserControls.uMonhocs uc = new UserControls.uMonhocs();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            UserControls.uLop uc = new UserControls.uLop();
            if (!pnMain.Controls.Contains(uc))
            {
                pnMain.Controls.Add(uc);
                uc.Dock = DockStyle.Fill;
                uc.BringToFront();
            }
            else
                uc.BringToFront();
        }
    }
}
