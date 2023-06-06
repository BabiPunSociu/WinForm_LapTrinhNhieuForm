using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai23_24_25_26____LapTrinhNhieu_FORM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool check_frm_tontai(string frmName, string frmText)
        {
            foreach(Form frm in this.MdiChildren)
            {
                if(frm.Name == frmName && frm.Text == frmText)
                    return true;
            }    
            return false;
        }

        void frmActive(string frmName, string frmText)
        {
            foreach(Form frm in this.MdiChildren)
            if (frm.Name == frmName && frm.Text == frmText)
            {
                frm.Activate(); // Hiển thị lên trên nhất
                break;
            }
        }

        private void phépCộng1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepCong", "Phép cộng 1"))
                frmActive("frmPhepCong", "Phép cộng 1");
            else
            {
                frmPhepCong frm = new frmPhepCong();
                frm.MdiParent = this;
                frm.Text = "Phép cộng 1";
                frm.Show();
            }    
        }

        private void phépCộng2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepCong", "Phép cộng 2"))
                frmActive("frmPhepCong", "Phép cộng 2");
            else
            {
                frmPhepCong frm = new frmPhepCong();
                frm.MdiParent = this;
                frm.Text = "Phép cộng 2";
                frm.Show();
            }
        }

        private void phépCộng3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepCong", "Phép cộng 3"))
                frmActive("frmPhepCong", "Phép cộng 3");
            else
            {
                frmPhepCong frm = new frmPhepCong();
                frm.MdiParent = this;
                frm.Text = "Phép cộng 3";
                frm.Show();
            }
        }

        private void phépCộng4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepCong", "Phép cộng 4"))
                frmActive("frmPhepCong", "Phép cộng 4");
            else
            {
                frmPhepCong frm = new frmPhepCong();
                frm.MdiParent = this;
                frm.Text = "Phép cộng 4";
                frm.Show();
            }
        }

        private void phépCộng5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepCong", "Phép cộng 5"))
                frmActive("frmPhepCong", "Phép cộng 5");
            else
            {
                frmPhepCong frm = new frmPhepCong();
                frm.MdiParent = this;
                frm.Text = "Phép cộng 5";
                frm.Show();
            }
        }

        private void phépTrừ1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepTru", "Phép trừ 1"))
                frmActive("frmPhepTru", "Phép trừ 1");
            else
            {
                frmPhepTru frm = new frmPhepTru();
                frm.MdiParent = this;
                frm.Text = "Phép trừ 1";
                frm.Show();
            }
        }

        private void phépTrừ2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (check_frm_tontai("frmPhepTru", "Phép trừ 2"))
                frmActive("frmPhepTru", "Phép trừ 2");
            else
            {
                frmPhepTru frm = new frmPhepTru();
                frm.MdiParent = this;
                frm.Text = "Phép trừ 2";
                frm.Show();
            }
        }
    }
}
