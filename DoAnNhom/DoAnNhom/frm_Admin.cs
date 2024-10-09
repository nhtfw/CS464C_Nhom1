using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom
{
    public partial class frm_Admin : Form
    {
        public frm_Admin()
        {
            InitializeComponent();
        }

        LopKetNoi ketnoi = new LopKetNoi();
        private void Btn_ThemNV_Click(object sender, EventArgs e)
        {
            string sql = "Insert into TBNhanVien values ('" + txt_AdminID.Text + "', '" + Txt_AdminTen.Text + "', '" + Txt_AdminHo.Text + "', '" + Txt_AdminPassword.Text + "', '" + Txt_CongViec.Text + "', '" + Txt_AdminTrangThai.Text + "', '" + Txt_AdminEmail.Text +"')";

            int kq = ketnoi.CapNhat(sql);

            if (kq >= 1)
            {
                MessageBox.Show("Thêm nhân viên thành công");

            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
           
        }

        public void loadNV()
        {

            string sql = "Select * from TBNhanVien";
            DataTable dt = ketnoi.Laydulieu(sql);
            dt_grivNhanVien.DataSource = dt;
        }

        private void Btn_LietKe_Click(object sender, EventArgs e)
        {
            loadNV();
        }

        private void Btn_XoaNV_Click(object sender, EventArgs e)
        {
            string sql = "Delete TBNhanVien where ID = '" + txt_AdminID.Text + "'";
            int kq = ketnoi.CapNhat(sql);
            if (kq >= 1) MessageBox.Show("Xoá nhân viên thành công");
            else MessageBox.Show("Xoá nhân viên  thất bại");
          

        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "Update TBNhanVien set Name = N'" + txt_AdminID.Text + "',Mame = N'" + Txt_AdminTen.Text + "',Surname = N '" + Txt_AdminHo.Text + "',Password = N '" + Txt_AdminPassword.Text + "',Job = N '" + Txt_CongViec.Text + "',Status = N '" + Txt_AdminTrangThai.Text + "',Email = N '" + Txt_AdminEmail.Text + "'";
            int kq = ketnoi.CapNhat(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật sv thành công");
            else MessageBox.Show("Cập nhật sv thất bại");
           
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng form này?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dt_grivNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            loadNV();
        }
    }
    
}
