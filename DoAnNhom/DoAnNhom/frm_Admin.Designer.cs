namespace DoAnNhom
{
    partial class frm_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_AdminID = new System.Windows.Forms.TextBox();
            this.Txt_AdminTen = new System.Windows.Forms.TextBox();
            this.Txt_AdminPassword = new System.Windows.Forms.TextBox();
            this.Txt_AdminHo = new System.Windows.Forms.TextBox();
            this.Txt_CongViec = new System.Windows.Forms.TextBox();
            this.Txt_AdminTrangThai = new System.Windows.Forms.TextBox();
            this.Txt_AdminEmail = new System.Windows.Forms.TextBox();
            this.Btn_ThemNV = new System.Windows.Forms.Button();
            this.Btn_XoaNV = new System.Windows.Forms.Button();
            this.Btn_CapNhat = new System.Windows.Forms.Button();
            this.Btn_LietKe = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.dt_grivNhanVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grivNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Họ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Công việc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(24, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Trang Thái";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(24, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // txt_AdminID
            // 
            this.txt_AdminID.Location = new System.Drawing.Point(139, 30);
            this.txt_AdminID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_AdminID.Name = "txt_AdminID";
            this.txt_AdminID.Size = new System.Drawing.Size(100, 22);
            this.txt_AdminID.TabIndex = 8;
            // 
            // Txt_AdminTen
            // 
            this.Txt_AdminTen.Location = new System.Drawing.Point(139, 65);
            this.Txt_AdminTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AdminTen.Name = "Txt_AdminTen";
            this.Txt_AdminTen.Size = new System.Drawing.Size(100, 22);
            this.Txt_AdminTen.TabIndex = 9;
            // 
            // Txt_AdminPassword
            // 
            this.Txt_AdminPassword.Location = new System.Drawing.Point(139, 135);
            this.Txt_AdminPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AdminPassword.Name = "Txt_AdminPassword";
            this.Txt_AdminPassword.Size = new System.Drawing.Size(100, 22);
            this.Txt_AdminPassword.TabIndex = 10;
            // 
            // Txt_AdminHo
            // 
            this.Txt_AdminHo.Location = new System.Drawing.Point(139, 101);
            this.Txt_AdminHo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AdminHo.Name = "Txt_AdminHo";
            this.Txt_AdminHo.Size = new System.Drawing.Size(100, 22);
            this.Txt_AdminHo.TabIndex = 11;
            // 
            // Txt_CongViec
            // 
            this.Txt_CongViec.Location = new System.Drawing.Point(139, 167);
            this.Txt_CongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_CongViec.Name = "Txt_CongViec";
            this.Txt_CongViec.Size = new System.Drawing.Size(100, 22);
            this.Txt_CongViec.TabIndex = 12;
            // 
            // Txt_AdminTrangThai
            // 
            this.Txt_AdminTrangThai.Location = new System.Drawing.Point(139, 204);
            this.Txt_AdminTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AdminTrangThai.Name = "Txt_AdminTrangThai";
            this.Txt_AdminTrangThai.Size = new System.Drawing.Size(100, 22);
            this.Txt_AdminTrangThai.TabIndex = 13;
            // 
            // Txt_AdminEmail
            // 
            this.Txt_AdminEmail.Location = new System.Drawing.Point(139, 238);
            this.Txt_AdminEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AdminEmail.Name = "Txt_AdminEmail";
            this.Txt_AdminEmail.Size = new System.Drawing.Size(100, 22);
            this.Txt_AdminEmail.TabIndex = 14;
            // 
            // Btn_ThemNV
            // 
            this.Btn_ThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ThemNV.Location = new System.Drawing.Point(449, 31);
            this.Btn_ThemNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ThemNV.Name = "Btn_ThemNV";
            this.Btn_ThemNV.Size = new System.Drawing.Size(147, 32);
            this.Btn_ThemNV.TabIndex = 15;
            this.Btn_ThemNV.Text = "Thêm nhân viên";
            this.Btn_ThemNV.UseVisualStyleBackColor = true;
            this.Btn_ThemNV.Click += new System.EventHandler(this.Btn_ThemNV_Click);
            // 
            // Btn_XoaNV
            // 
            this.Btn_XoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_XoaNV.Location = new System.Drawing.Point(449, 69);
            this.Btn_XoaNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_XoaNV.Name = "Btn_XoaNV";
            this.Btn_XoaNV.Size = new System.Drawing.Size(147, 37);
            this.Btn_XoaNV.TabIndex = 16;
            this.Btn_XoaNV.Text = "Xóa Nhân Viên";
            this.Btn_XoaNV.UseVisualStyleBackColor = true;
            this.Btn_XoaNV.Click += new System.EventHandler(this.Btn_XoaNV_Click);
            // 
            // Btn_CapNhat
            // 
            this.Btn_CapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_CapNhat.Location = new System.Drawing.Point(449, 112);
            this.Btn_CapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_CapNhat.Name = "Btn_CapNhat";
            this.Btn_CapNhat.Size = new System.Drawing.Size(147, 30);
            this.Btn_CapNhat.TabIndex = 17;
            this.Btn_CapNhat.Text = "Sửa Nhân Viên";
            this.Btn_CapNhat.UseVisualStyleBackColor = true;
            this.Btn_CapNhat.Click += new System.EventHandler(this.Btn_CapNhat_Click);
            // 
            // Btn_LietKe
            // 
            this.Btn_LietKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_LietKe.Location = new System.Drawing.Point(449, 148);
            this.Btn_LietKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_LietKe.Name = "Btn_LietKe";
            this.Btn_LietKe.Size = new System.Drawing.Size(147, 37);
            this.Btn_LietKe.TabIndex = 18;
            this.Btn_LietKe.Text = "Liệt Kê Nhân ";
            this.Btn_LietKe.UseVisualStyleBackColor = true;
            this.Btn_LietKe.Click += new System.EventHandler(this.Btn_LietKe_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Thoat.Location = new System.Drawing.Point(449, 191);
            this.Btn_Thoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(147, 32);
            this.Btn_Thoat.TabIndex = 19;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = true;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // dt_grivNhanVien
            // 
            this.dt_grivNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_grivNhanVien.Location = new System.Drawing.Point(27, 311);
            this.dt_grivNhanVien.Name = "dt_grivNhanVien";
            this.dt_grivNhanVien.RowTemplate.Height = 24;
            this.dt_grivNhanVien.Size = new System.Drawing.Size(914, 171);
            this.dt_grivNhanVien.TabIndex = 20;
            this.dt_grivNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_grivNhanVien_CellContentClick);
            // 
            // frm_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1023, 500);
            this.Controls.Add(this.dt_grivNhanVien);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Btn_LietKe);
            this.Controls.Add(this.Btn_CapNhat);
            this.Controls.Add(this.Btn_XoaNV);
            this.Controls.Add(this.Btn_ThemNV);
            this.Controls.Add(this.Txt_AdminEmail);
            this.Controls.Add(this.Txt_AdminTrangThai);
            this.Controls.Add(this.Txt_CongViec);
            this.Controls.Add(this.Txt_AdminHo);
            this.Controls.Add(this.Txt_AdminPassword);
            this.Controls.Add(this.Txt_AdminTen);
            this.Controls.Add(this.txt_AdminID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Admin";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grivNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_AdminID;
        private System.Windows.Forms.TextBox Txt_AdminTen;
        private System.Windows.Forms.TextBox Txt_AdminPassword;
        private System.Windows.Forms.TextBox Txt_AdminHo;
        private System.Windows.Forms.TextBox Txt_CongViec;
        private System.Windows.Forms.TextBox Txt_AdminTrangThai;
        private System.Windows.Forms.TextBox Txt_AdminEmail;

        private System.Windows.Forms.BindingSource staffBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Btn_ThemNV;
        private System.Windows.Forms.Button Btn_XoaNV;
        private System.Windows.Forms.Button Btn_CapNhat;
        private System.Windows.Forms.Button Btn_LietKe;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.DataGridView dt_grivNhanVien;
    }
}