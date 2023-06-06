using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai23_24_25_26____LapTrinhNhieu_FORM
{
    public partial class frmPhepTru : Form
    {
        List<int> DA = new List<int>();
        public frmPhepTru()
        {
            InitializeComponent();
        }

        private void frmPhepTru_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                Random rd = new Random();
                int x = rd.Next();
                int y = rd.Next();
                DA.Add(x - y);

                string lblName = "label" + (i + 2); // label [2,11]

                foreach (Control control in groupBox1.Controls)
                {
                    if (control.Name == lblName)
                    {
                        control.Text = x + " - " + y + " = ";
                        break;
                    }
                }
            }
        }
        public int kiemTra(TextBox txt, int index)
        {
            if (txt.Text.Trim() == DA[index].ToString())
            {
                txt.BackColor = Color.Cyan;
                return 1;
            }
            else txt.BackColor = Color.HotPink;
            return 0;
        }
        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            int diem = kiemTra(txt0, 0) + kiemTra(txt1, 1) + kiemTra(txt2, 2) + kiemTra(txt3, 3) + kiemTra(txt4, 4) + kiemTra(txt5, 5) + kiemTra(txt6, 6) + kiemTra(txt7, 7) + kiemTra(txt8, 8) + kiemTra(txt9, 9);
            MessageBox.Show("Bạn được " + diem + " điểm");
        }

        public void resetTextBox(TextBox txt)
        {
            txt.Clear();
            txt.BackColor = Color.White;
        }
        private void btnLamLai_Click(object sender, EventArgs e)
        {
            resetTextBox(txt0);
            resetTextBox(txt1);
            resetTextBox(txt2);
            resetTextBox(txt3);
            resetTextBox(txt4);
            resetTextBox(txt5);
            resetTextBox(txt6);
            resetTextBox(txt7);
            resetTextBox(txt8);
            resetTextBox(txt9);
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            txt0.Text = DA[0].ToString();
            txt1.Text = DA[1].ToString();
            txt2.Text = DA[2].ToString();
            txt3.Text = DA[3].ToString();
            txt4.Text = DA[4].ToString();
            txt5.Text = DA[5].ToString();
            txt6.Text = DA[6].ToString();
            txt7.Text = DA[7].ToString();
            txt8.Text = DA[8].ToString();
            txt9.Text = DA[9].ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi bài tập phép cộng này không?", "Cảnh báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void NhapSo(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '-'))
                e.Handled = true;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }
        }

    }
}
