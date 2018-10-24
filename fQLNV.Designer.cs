namespace WindowsFormsApp8
{
    partial class fQLNV
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNV = new System.Windows.Forms.DateTimePicker();
            this.btLuuNV = new System.Windows.Forms.Button();
            this.btThemNV = new System.Windows.Forms.Button();
            this.btTimNV = new System.Windows.Forms.Button();
            this.cbbGioiTinhNV = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChiNV = new System.Windows.Forms.TextBox();
            this.txtSDTNV = new System.Windows.Forms.TextBox();
            this.txtTimNV = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btHome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvQLNV = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpNV);
            this.panel2.Controls.Add(this.btLuuNV);
            this.panel2.Controls.Add(this.btThemNV);
            this.panel2.Controls.Add(this.btTimNV);
            this.panel2.Controls.Add(this.cbbGioiTinhNV);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtDiaChiNV);
            this.panel2.Controls.Add(this.txtSDTNV);
            this.panel2.Controls.Add(this.txtTimNV);
            this.panel2.Controls.Add(this.txtTenNV);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 172);
            this.panel2.TabIndex = 4;
            // 
            // dtpNV
            // 
            this.dtpNV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNV.Location = new System.Drawing.Point(136, 80);
            this.dtpNV.Name = "dtpNV";
            this.dtpNV.Size = new System.Drawing.Size(279, 30);
            this.dtpNV.TabIndex = 3;
            // 
            // btLuuNV
            // 
            this.btLuuNV.Location = new System.Drawing.Point(754, 116);
            this.btLuuNV.Name = "btLuuNV";
            this.btLuuNV.Size = new System.Drawing.Size(101, 43);
            this.btLuuNV.TabIndex = 8;
            this.btLuuNV.Text = "Lưu";
            this.btLuuNV.UseVisualStyleBackColor = true;
            // 
            // btThemNV
            // 
            this.btThemNV.Location = new System.Drawing.Point(586, 116);
            this.btThemNV.Name = "btThemNV";
            this.btThemNV.Size = new System.Drawing.Size(101, 43);
            this.btThemNV.TabIndex = 7;
            this.btThemNV.Text = "Thêm";
            this.btThemNV.UseVisualStyleBackColor = true;
            // 
            // btTimNV
            // 
            this.btTimNV.Location = new System.Drawing.Point(314, 116);
            this.btTimNV.Name = "btTimNV";
            this.btTimNV.Size = new System.Drawing.Size(101, 43);
            this.btTimNV.TabIndex = 10;
            this.btTimNV.Text = "Tìm kiếm";
            this.btTimNV.UseVisualStyleBackColor = true;
            // 
            // cbbGioiTinhNV
            // 
            this.cbbGioiTinhNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbGioiTinhNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGioiTinhNV.FormattingEnabled = true;
            this.cbbGioiTinhNV.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbGioiTinhNV.Location = new System.Drawing.Point(599, 6);
            this.cbbGioiTinhNV.Name = "cbbGioiTinhNV";
            this.cbbGioiTinhNV.Size = new System.Drawing.Size(255, 30);
            this.cbbGioiTinhNV.TabIndex = 4;
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
            // txtDiaChiNV
            // 
            this.txtDiaChiNV.Location = new System.Drawing.Point(586, 80);
            this.txtDiaChiNV.Name = "txtDiaChiNV";
            this.txtDiaChiNV.Size = new System.Drawing.Size(268, 30);
            this.txtDiaChiNV.TabIndex = 6;
            // 
            // txtSDTNV
            // 
            this.txtSDTNV.Location = new System.Drawing.Point(630, 44);
            this.txtSDTNV.Name = "txtSDTNV";
            this.txtSDTNV.Size = new System.Drawing.Size(224, 30);
            this.txtSDTNV.TabIndex = 5;
            // 
            // txtTimNV
            // 
            this.txtTimNV.Location = new System.Drawing.Point(48, 123);
            this.txtTimNV.Name = "txtTimNV";
            this.txtTimNV.Size = new System.Drawing.Size(260, 30);
            this.txtTimNV.TabIndex = 9;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(166, 44);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(249, 30);
            this.txtTenNV.TabIndex = 2;
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
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tên nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(161, 8);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(254, 30);
            this.txtMaNV.TabIndex = 1;
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
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 39);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Image = global::WindowsFormsApp8.Properties.Resources.icons8_Home_30px;
            this.btHome.Location = new System.Drawing.Point(855, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 39);
            this.btHome.TabIndex = 0;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(908, 403);
            this.dataGridView1.TabIndex = 5;
            // 
            // dgvQLNV
            // 
            this.dgvQLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.ngaysinh,
            this.gioitinh,
            this.sdt,
            this.diachi});
            this.dgvQLNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLNV.Location = new System.Drawing.Point(0, 211);
            this.dgvQLNV.Name = "dgvQLNV";
            this.dgvQLNV.RowTemplate.Height = 24;
            this.dgvQLNV.Size = new System.Drawing.Size(908, 403);
            this.dgvQLNV.TabIndex = 6;
            // 
            // id
            // 
            this.id.HeaderText = "Mã nhân viên";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Tên nhân viên";
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
            // fQLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 614);
            this.Controls.Add(this.dgvQLNV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fQLNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fQLNV";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpNV;
        private System.Windows.Forms.Button btLuuNV;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.Button btTimNV;
        private System.Windows.Forms.ComboBox cbbGioiTinhNV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChiNV;
        private System.Windows.Forms.TextBox txtSDTNV;
        private System.Windows.Forms.TextBox txtTimNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgvQLNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}