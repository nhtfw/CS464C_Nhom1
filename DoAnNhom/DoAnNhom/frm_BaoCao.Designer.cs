namespace DoAnNhom
{
    partial class frm_BaoCao
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
            this.btn_baocaohangngay = new System.Windows.Forms.Button();
            this.btn_baocaohangthang = new System.Windows.Forms.Button();
            this.btn_baocaohangnam = new System.Windows.Forms.Button();
            this.DgrReports = new System.Windows.Forms.DataGridView();
            this.LblReportsName = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IdCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaiterIDCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmountCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderContentsCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTableCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDateCollum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusCollum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TableStatusCollum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgrReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_baocaohangngay
            // 
            this.btn_baocaohangngay.Location = new System.Drawing.Point(91, 37);
            this.btn_baocaohangngay.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baocaohangngay.Name = "btn_baocaohangngay";
            this.btn_baocaohangngay.Size = new System.Drawing.Size(105, 42);
            this.btn_baocaohangngay.TabIndex = 0;
            this.btn_baocaohangngay.Text = "Báo cáo hàng ngày";
            this.btn_baocaohangngay.UseVisualStyleBackColor = true;
            // 
            // btn_baocaohangthang
            // 
            this.btn_baocaohangthang.Location = new System.Drawing.Point(336, 37);
            this.btn_baocaohangthang.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baocaohangthang.Name = "btn_baocaohangthang";
            this.btn_baocaohangthang.Size = new System.Drawing.Size(102, 42);
            this.btn_baocaohangthang.TabIndex = 1;
            this.btn_baocaohangthang.Text = "Báo cáo hàng tháng";
            this.btn_baocaohangthang.UseVisualStyleBackColor = true;
            // 
            // btn_baocaohangnam
            // 
            this.btn_baocaohangnam.Location = new System.Drawing.Point(602, 37);
            this.btn_baocaohangnam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_baocaohangnam.Name = "btn_baocaohangnam";
            this.btn_baocaohangnam.Size = new System.Drawing.Size(113, 42);
            this.btn_baocaohangnam.TabIndex = 2;
            this.btn_baocaohangnam.Text = "Báo cáo hàng năm";
            this.btn_baocaohangnam.UseVisualStyleBackColor = true;
            // 
            // DgrReports
            // 
            this.DgrReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgrReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgrReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCollum,
            this.WaiterIDCollum,
            this.OrderAmountCollum,
            this.OrderContentsCollum,
            this.OrderTableCollum,
            this.OrderDateCollum,
            this.OrderStatusCollum,
            this.TableStatusCollum});
            this.DgrReports.Location = new System.Drawing.Point(24, 172);
            this.DgrReports.Margin = new System.Windows.Forms.Padding(2);
            this.DgrReports.Name = "DgrReports";
            this.DgrReports.RowHeadersWidth = 51;
            this.DgrReports.RowTemplate.Height = 24;
            this.DgrReports.Size = new System.Drawing.Size(790, 222);
            this.DgrReports.TabIndex = 3;
            this.DgrReports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgrReports_CellContentClick);
            // 
            // LblReportsName
            // 
            this.LblReportsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblReportsName.Location = new System.Drawing.Point(47, 125);
            this.LblReportsName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblReportsName.Name = "LblReportsName";
            this.LblReportsName.Size = new System.Drawing.Size(160, 28);
            this.LblReportsName.TabIndex = 4;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            // 
            // IdCollum
            // 
            this.IdCollum.HeaderText = "ID";
            this.IdCollum.MinimumWidth = 6;
            this.IdCollum.Name = "IdCollum";
            // 
            // WaiterIDCollum
            // 
            this.WaiterIDCollum.HeaderText = "ID Nhân viên";
            this.WaiterIDCollum.MinimumWidth = 6;
            this.WaiterIDCollum.Name = "WaiterIDCollum";
            // 
            // OrderAmountCollum
            // 
            this.OrderAmountCollum.HeaderText = "SL đơn đặt";
            this.OrderAmountCollum.MinimumWidth = 6;
            this.OrderAmountCollum.Name = "OrderAmountCollum";
            // 
            // OrderContentsCollum
            // 
            this.OrderContentsCollum.HeaderText = "Nội dung";
            this.OrderContentsCollum.MinimumWidth = 6;
            this.OrderContentsCollum.Name = "OrderContentsCollum";
            // 
            // OrderTableCollum
            // 
            this.OrderTableCollum.HeaderText = "Bảng đặt hàng";
            this.OrderTableCollum.MinimumWidth = 6;
            this.OrderTableCollum.Name = "OrderTableCollum";
            // 
            // OrderDateCollum
            // 
            this.OrderDateCollum.HeaderText = "Ngày đặt";
            this.OrderDateCollum.MinimumWidth = 6;
            this.OrderDateCollum.Name = "OrderDateCollum";
            // 
            // OrderStatusCollum
            // 
            this.OrderStatusCollum.HeaderText = "Trang thái";
            this.OrderStatusCollum.MinimumWidth = 6;
            this.OrderStatusCollum.Name = "OrderStatusCollum";
            this.OrderStatusCollum.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderStatusCollum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TableStatusCollum
            // 
            this.TableStatusCollum.HeaderText = "Bảng trạng thái";
            this.TableStatusCollum.MinimumWidth = 6;
            this.TableStatusCollum.Name = "TableStatusCollum";
            // 
            // frm_BaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 457);
            this.Controls.Add(this.LblReportsName);
            this.Controls.Add(this.DgrReports);
            this.Controls.Add(this.btn_baocaohangnam);
            this.Controls.Add(this.btn_baocaohangthang);
            this.Controls.Add(this.btn_baocaohangngay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_BaoCao";
            this.Text = "ReportsForm";
            ((System.ComponentModel.ISupportInitialize)(this.DgrReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_baocaohangngay;
        private System.Windows.Forms.Button btn_baocaohangthang;
        private System.Windows.Forms.Button btn_baocaohangnam;
        private System.Windows.Forms.DataGridView DgrReports;

        private System.Windows.Forms.BindingSource ordersBindingSource;

        private System.Windows.Forms.Label LblReportsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaiterIDCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmountCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderContentsCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTableCollum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateCollum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OrderStatusCollum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TableStatusCollum;
    }
}