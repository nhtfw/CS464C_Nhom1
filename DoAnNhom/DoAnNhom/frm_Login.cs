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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        LopKetNoi ketNoi = new LopKetNoi();

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text.Trim();
            string password = txt_matkhau.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = $"SELECT * FROM TBNhanVien WHERE Email = '{email}' AND Password = '{password}'";
            DataTable dt = ketNoi.Laydulieu(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string job = dr["Job"].ToString();

                switch (job)
                {
                    case "Admin":
                        // Open Admin Form
                        frm_Admin adminForm = new frm_Admin();
                        adminForm.Show();
                        break;
                    case "Cashier":
                        // Open Cashier Form
                        frm_ThuNgan thungan = new frm_ThuNgan();
                        thungan.Show();
                        break;
                    case "Waiter":
                        // Open Waiter Form
                        frm_DatHang waiterForm = new frm_DatHang();
                        waiterForm.Show();
                        break;
                    case "KitchenWorker":
                        // Open Kitchen Worker Form
                        frm_NhanVienBep kitchenWorkerForm = new frm_NhanVienBep();
                        kitchenWorkerForm.Show();
                        break;
                   
                    default:
                        MessageBox.Show("Unknown job title.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
