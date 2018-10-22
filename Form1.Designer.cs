namespace WindowsFormsApp8
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btQLTT = new System.Windows.Forms.Button();
            this.btQLKH = new System.Windows.Forms.Button();
            this.btQLNV = new System.Windows.Forms.Button();
            this.btQLS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(853, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 37);
            this.btnClose.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(901, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hệ thống quản lý thư viện";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.BackColor = System.Drawing.Color.Black;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // btQLTT
            // 
            this.btQLTT.BackColor = System.Drawing.Color.White;
            this.btQLTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btQLTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLTT.Image = global::WindowsFormsApp8.Properties.Resources.back;
            this.btQLTT.Location = new System.Drawing.Point(541, 187);
            this.btQLTT.Name = "btQLTT";
            this.btQLTT.Size = new System.Drawing.Size(262, 115);
            this.btQLTT.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btQLTT, "Quản lý thuê trả");
            this.btQLTT.UseVisualStyleBackColor = false;
            this.btQLTT.Click += new System.EventHandler(this.btQLTT_Click);
            // 
            // btQLKH
            // 
            this.btQLKH.BackColor = System.Drawing.Color.White;
            this.btQLKH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLKH.Image = global::WindowsFormsApp8.Properties.Resources.customer_vector_clip_art_4;
            this.btQLKH.Location = new System.Drawing.Point(102, 391);
            this.btQLKH.Name = "btQLKH";
            this.btQLKH.Size = new System.Drawing.Size(262, 115);
            this.btQLKH.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btQLKH, "Quản lý khách hàng");
            this.btQLKH.UseVisualStyleBackColor = false;
            // 
            // btQLNV
            // 
            this.btQLNV.BackColor = System.Drawing.Color.White;
            this.btQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLNV.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btQLNV.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btQLNV.Image = global::WindowsFormsApp8.Properties.Resources.content_ui_img_icons_png_cs_768x768;
            this.btQLNV.Location = new System.Drawing.Point(541, 391);
            this.btQLNV.Name = "btQLNV";
            this.btQLNV.Size = new System.Drawing.Size(262, 115);
            this.btQLNV.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btQLNV, "Quản lý nhân viên");
            this.btQLNV.UseVisualStyleBackColor = false;
            // 
            // btQLS
            // 
            this.btQLS.BackColor = System.Drawing.Color.White;
            this.btQLS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btQLS.Image = global::WindowsFormsApp8.Properties.Resources.icons8_Book_Shelf_96px;
            this.btQLS.Location = new System.Drawing.Point(102, 187);
            this.btQLS.Name = "btQLS";
            this.btQLS.Size = new System.Drawing.Size(262, 115);
            this.btQLS.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btQLS, "Quản lý sách");
            this.btQLS.UseVisualStyleBackColor = false;
            this.btQLS.Click += new System.EventHandler(this.btQLS_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quản lý sách";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quản lý thuê trả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 509);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quản lý nhân viên";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(102, 509);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quản lý khách hàng";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Trang chủ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(901, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btQLTT);
            this.Controls.Add(this.btQLKH);
            this.Controls.Add(this.btQLNV);
            this.Controls.Add(this.btQLS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btQLS;
        private System.Windows.Forms.Button btQLNV;
        private System.Windows.Forms.Button btQLKH;
        private System.Windows.Forms.Button btQLTT;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

