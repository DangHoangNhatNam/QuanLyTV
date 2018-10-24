namespace WindowsFormsApp8
{
    partial class fQLKT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btLuuKhach = new System.Windows.Forms.Button();
            this.btThemKhach = new System.Windows.Forms.Button();
            this.btTimKhach = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDTKhach = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaKhach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQLKT = new System.Windows.Forms.DataGridView();
            this.dtpKhach = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinhKhach = new System.Windows.Forms.ComboBox();
            this.txtDiaChiKhach = new System.Windows.Forms.TextBox();
            this.txtTimKhach = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKT)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 39);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý khách thuê";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpKhach);
            this.panel2.Controls.Add(this.btLuuKhach);
            this.panel2.Controls.Add(this.btThemKhach);
            this.panel2.Controls.Add(this.btTimKhach);
            this.panel2.Controls.Add(this.cbbGioiTinhKhach);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiaChiKhach);
            this.panel2.Controls.Add(this.txtSDTKhach);
            this.panel2.Controls.Add(this.txtTimKhach);
            this.panel2.Controls.Add(this.txtTenKhach);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaKhach);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 172);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvQLKT);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 395);
            this.panel3.TabIndex = 3;
            // 
            // btLuuKhach
            // 
            this.btLuuKhach.Location = new System.Drawing.Point(754, 116);
            this.btLuuKhach.Name = "btLuuKhach";
            this.btLuuKhach.Size = new System.Drawing.Size(101, 43);
            this.btLuuKhach.TabIndex = 8;
            this.btLuuKhach.Text = "Lưu";
            this.btLuuKhach.UseVisualStyleBackColor = true;
            // 
            // btThemKhach
            // 
            this.btThemKhach.Location = new System.Drawing.Point(586, 116);
            this.btThemKhach.Name = "btThemKhach";
            this.btThemKhach.Size = new System.Drawing.Size(101, 43);
            this.btThemKhach.TabIndex = 7;
            this.btThemKhach.Text = "Thêm";
            this.btThemKhach.UseVisualStyleBackColor = true;
            // 
            // btTimKhach
            // 
            this.btTimKhach.Location = new System.Drawing.Point(280, 116);
            this.btTimKhach.Name = "btTimKhach";
            this.btTimKhach.Size = new System.Drawing.Size(101, 43);
            this.btTimKhach.TabIndex = 10;
            this.btTimKhach.Text = "Tìm kiếm";
            this.btTimKhach.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(512, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày sinh";
            // 
            // txtSDTKhach
            // 
            this.txtSDTKhach.Location = new System.Drawing.Point(630, 44);
            this.txtSDTKhach.Name = "txtSDTKhach";
            this.txtSDTKhach.Size = new System.Drawing.Size(224, 30);
            this.txtSDTKhach.TabIndex = 5;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(136, 44);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(245, 30);
            this.txtTenKhach.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(512, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên khách";
            // 
            // txtMaKhach
            // 
            this.txtMaKhach.Location = new System.Drawing.Point(136, 8);
            this.txtMaKhach.Name = "txtMaKhach";
            this.txtMaKhach.ReadOnly = true;
            this.txtMaKhach.Size = new System.Drawing.Size(245, 30);
            this.txtMaKhach.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(512, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã khách";
            // 
            // dgvQLKT
            // 
            this.dgvQLKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.diachi});
            this.dgvQLKT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLKT.Location = new System.Drawing.Point(0, 0);
            this.dgvQLKT.Name = "dgvQLKT";
            this.dgvQLKT.RowTemplate.Height = 24;
            this.dgvQLKT.Size = new System.Drawing.Size(903, 395);
            this.dgvQLKT.TabIndex = 0;
            // 
            // dtpKhach
            // 
            this.dtpKhach.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKhach.Location = new System.Drawing.Point(136, 80);
            this.dtpKhach.Name = "dtpKhach";
            this.dtpKhach.Size = new System.Drawing.Size(245, 30);
            this.dtpKhach.TabIndex = 3;
            // 
            // cbbGioiTinhKhach
            // 
            this.cbbGioiTinhKhach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbGioiTinhKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinhKhach.FormattingEnabled = true;
            this.cbbGioiTinhKhach.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinhKhach.Location = new System.Drawing.Point(599, 6);
            this.cbbGioiTinhKhach.Name = "cbbGioiTinhKhach";
            this.cbbGioiTinhKhach.Size = new System.Drawing.Size(255, 30);
            this.cbbGioiTinhKhach.TabIndex = 4;
            // 
            // txtDiaChiKhach
            // 
            this.txtDiaChiKhach.Location = new System.Drawing.Point(586, 80);
            this.txtDiaChiKhach.Name = "txtDiaChiKhach";
            this.txtDiaChiKhach.Size = new System.Drawing.Size(268, 30);
            this.txtDiaChiKhach.TabIndex = 6;
            // 
            // txtTimKhach
            // 
            this.txtTimKhach.Location = new System.Drawing.Point(48, 123);
            this.txtTimKhach.Name = "txtTimKhach";
            this.txtTimKhach.Size = new System.Drawing.Size(226, 30);
            this.txtTimKhach.TabIndex = 9;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Image = global::WindowsFormsApp8.Properties.Resources.icons8_Home_30px;
            this.btHome.Location = new System.Drawing.Point(850, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 39);
            this.btHome.TabIndex = 0;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // id
            // 
            this.id.HeaderText = "Mã khách";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 80;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên khách";
            this.name.Name = "name";
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày sinh";
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 120;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.Name = "gioitinh";
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.Width = 120;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            // 
            // fQLKT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 606);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQLKT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQLKT";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLKT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btLuuKhach;
        private System.Windows.Forms.Button btThemKhach;
        private System.Windows.Forms.Button btTimKhach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDTKhach;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKhach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvQLKT;
        private System.Windows.Forms.DateTimePicker dtpKhach;
        private System.Windows.Forms.ComboBox cbbGioiTinhKhach;
        private System.Windows.Forms.TextBox txtDiaChiKhach;
        private System.Windows.Forms.TextBox txtTimKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}