namespace DoAnNhom
{
    partial class frm_Login
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
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(283, 85);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(45, 18);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(283, 192);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(71, 18);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "Mật Khẩu";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(286, 125);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(148, 24);
            this.txt_email.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(286, 226);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(148, 24);
            this.txt_matkhau.TabIndex = 3;
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Location = new System.Drawing.Point(282, 289);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(152, 42);
            this.btn_dangnhap.TabIndex = 4;
            this.btn_dangnhap.Text = "Đăng Nhập";
            this.btn_dangnhap.UseVisualStyleBackColor = true;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "frm_Login";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_dangnhap;
    }
}

