namespace WindowsFormsApp8
{
    partial class fQLTT
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
            this.tcHoaDon = new System.Windows.Forms.TabControl();
            this.tpThue = new System.Windows.Forms.TabPage();
            this.tpTra = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcHoaDon.SuspendLayout();
            this.tpThue.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(897, 39);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thuê trả";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tcHoaDon
            // 
            this.tcHoaDon.Controls.Add(this.tpThue);
            this.tcHoaDon.Controls.Add(this.tpTra);
            this.tcHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcHoaDon.Location = new System.Drawing.Point(0, 39);
            this.tcHoaDon.Name = "tcHoaDon";
            this.tcHoaDon.SelectedIndex = 0;
            this.tcHoaDon.Size = new System.Drawing.Size(897, 548);
            this.tcHoaDon.TabIndex = 2;
            // 
            // tpThue
            // 
            this.tpThue.Controls.Add(this.panel3);
            this.tpThue.Controls.Add(this.panel2);
            this.tpThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpThue.Location = new System.Drawing.Point(4, 31);
            this.tpThue.Name = "tpThue";
            this.tpThue.Padding = new System.Windows.Forms.Padding(3);
            this.tpThue.Size = new System.Drawing.Size(889, 513);
            this.tpThue.TabIndex = 0;
            this.tpThue.Text = "Thuê sách";
            this.tpThue.UseVisualStyleBackColor = true;
            // 
            // tpTra
            // 
            this.tpTra.Location = new System.Drawing.Point(4, 31);
            this.tpTra.Name = "tpTra";
            this.tpTra.Padding = new System.Windows.Forms.Padding(3);
            this.tpTra.Size = new System.Drawing.Size(889, 513);
            this.tpTra.TabIndex = 1;
            this.tpTra.Text = "Trả sách";
            this.tpTra.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 97);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 410);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(883, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // btHome
            // 
            this.btHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHome.FlatAppearance.BorderSize = 0;
            this.btHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHome.Image = global::WindowsFormsApp8.Properties.Resources.icons8_Home_30px;
            this.btHome.Location = new System.Drawing.Point(844, 0);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(53, 39);
            this.btHome.TabIndex = 0;
            this.btHome.UseVisualStyleBackColor = true;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // fQLTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 587);
            this.Controls.Add(this.tcHoaDon);
            this.Controls.Add(this.panel1);
            this.Name = "fQLTT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuê trả";
            this.panel1.ResumeLayout(false);
            this.tcHoaDon.ResumeLayout(false);
            this.tpThue.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btHome;
        private System.Windows.Forms.TabControl tcHoaDon;
        private System.Windows.Forms.TabPage tpThue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tpTra;
    }
}