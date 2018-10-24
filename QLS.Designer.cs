namespace WindowsFormsApp8
{
    partial class QLS
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btLuuSach = new System.Windows.Forms.Button();
            this.btThemSach = new System.Windows.Forms.Button();
            this.btTimSach = new System.Windows.Forms.Button();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvQLS = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nxb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cbbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTimKhach = new System.Windows.Forms.TextBox();
            this.btHome = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(942, 203);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLuuSach);
            this.groupBox1.Controls.Add(this.btThemSach);
            this.groupBox1.Controls.Add(this.btTimSach);
            this.groupBox1.Controls.Add(this.cbbTrangThai);
            this.groupBox1.Controls.Add(this.cbbTheLoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTimKhach);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtMaSach);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(942, 203);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sách";
            // 
            // btLuuSach
            // 
            this.btLuuSach.Location = new System.Drawing.Point(270, 143);
            this.btLuuSach.Name = "btLuuSach";
            this.btLuuSach.Size = new System.Drawing.Size(101, 43);
            this.btLuuSach.TabIndex = 8;
            this.btLuuSach.Text = "Lưu";
            this.btLuuSach.UseVisualStyleBackColor = true;
            // 
            // btThemSach
            // 
            this.btThemSach.Location = new System.Drawing.Point(126, 143);
            this.btThemSach.Name = "btThemSach";
            this.btThemSach.Size = new System.Drawing.Size(101, 43);
            this.btThemSach.TabIndex = 7;
            this.btThemSach.Text = "Thêm";
            this.btThemSach.UseVisualStyleBackColor = true;
            // 
            // btTimSach
            // 
            this.btTimSach.Location = new System.Drawing.Point(818, 143);
            this.btTimSach.Name = "btTimSach";
            this.btTimSach.Size = new System.Drawing.Size(101, 43);
            this.btTimSach.TabIndex = 10;
            this.btTimSach.Text = "Tìm kiếm";
            this.btTimSach.UseVisualStyleBackColor = true;
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(126, 105);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(245, 30);
            this.cbbTheLoai.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(443, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Thể loại";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(561, 69);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(224, 30);
            this.txtNXB.TabIndex = 5;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(90, 69);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(281, 30);
            this.txtTenSach.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(443, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhà xuất bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên";
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(518, 33);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(267, 30);
            this.txtTacGia.TabIndex = 4;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(126, 33);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.ReadOnly = true;
            this.txtMaSach.Size = new System.Drawing.Size(245, 30);
            this.txtMaSach.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tác giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã sách";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvQLS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(942, 411);
            this.panel4.TabIndex = 3;
            // 
            // dgvQLS
            // 
            this.dgvQLS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.tacgia,
            this.nxb,
            this.theloai,
            this.trangthai,
            this.sua,
            this.xoa});
            this.dgvQLS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQLS.Location = new System.Drawing.Point(0, 0);
            this.dgvQLS.Name = "dgvQLS";
            this.dgvQLS.RowTemplate.Height = 24;
            this.dgvQLS.Size = new System.Drawing.Size(942, 411);
            this.dgvQLS.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 39);
            this.panel1.TabIndex = 0;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "id";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // tensach
            // 
            this.tensach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tensach.DataPropertyName = "name";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // tacgia
            // 
            this.tacgia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tacgia.DataPropertyName = "tacgia";
            this.tacgia.HeaderText = "Tác giả";
            this.tacgia.Name = "tacgia";
            // 
            // nxb
            // 
            this.nxb.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nxb.DataPropertyName = "nxb";
            this.nxb.HeaderText = "Nhà xuất bản";
            this.nxb.Name = "nxb";
            // 
            // theloai
            // 
            this.theloai.DataPropertyName = "theloai";
            this.theloai.HeaderText = "Thể loại";
            this.theloai.Name = "theloai";
            // 
            // trangthai
            // 
            this.trangthai.DataPropertyName = "trangthai";
            this.trangthai.HeaderText = "Trạng thái";
            this.trangthai.Name = "trangthai";
            // 
            // sua
            // 
            this.sua.HeaderText = "Sửa";
            this.sua.Name = "sua";
            this.sua.Width = 40;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.Name = "xoa";
            this.xoa.Width = 40;
            // 
            // cbbTrangThai
            // 
            this.cbbTrangThai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTrangThai.FormattingEnabled = true;
            this.cbbTrangThai.Items.AddRange(new object[] {
            "Tồn tại",
            "Đã thuê"});
            this.cbbTrangThai.Location = new System.Drawing.Point(538, 105);
            this.cbbTrangThai.Name = "cbbTrangThai";
            this.cbbTrangThai.Size = new System.Drawing.Size(247, 30);
            this.cbbTrangThai.TabIndex = 6;
            // 
            // txtTimKhach
            // 
            this.txtTimKhach.Location = new System.Drawing.Point(593, 150);
            this.txtTimKhach.Name = "txtTimKhach";
            this.txtTimKhach.Size = new System.Drawing.Size(219, 30);
            this.txtTimKhach.TabIndex = 9;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Image = global::WindowsFormsApp8.Properties.Resources.icons8_Home_30px;
            this.btHome.Location = new System.Drawing.Point(889, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 39);
            this.btHome.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btHome, "Home");
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // QLS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QLS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLS";
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btLuuSach;
        private System.Windows.Forms.Button btThemSach;
        private System.Windows.Forms.Button btTimSach;
        private System.Windows.Forms.DataGridView dgvQLS;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn nxb;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangthai;
        private System.Windows.Forms.DataGridViewButtonColumn sua;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
        private System.Windows.Forms.ComboBox cbbTrangThai;
        private System.Windows.Forms.TextBox txtTimKhach;
    }
}