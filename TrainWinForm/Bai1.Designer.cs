namespace TrainWinForm
{
    partial class frmQuanLiSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTIn = new System.Windows.Forms.GroupBox();
            this.drvSinhVien = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMASV = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drvSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(329, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lí Sinh Viên";
            // 
            // grbThongTIn
            // 
            this.grbThongTIn.Controls.Add(this.drvSinhVien);
            this.grbThongTIn.Location = new System.Drawing.Point(12, 334);
            this.grbThongTIn.Name = "grbThongTIn";
            this.grbThongTIn.Size = new System.Drawing.Size(922, 369);
            this.grbThongTIn.TabIndex = 1;
            this.grbThongTIn.TabStop = false;
            this.grbThongTIn.Text = "Thông Tin Sinh Viên";
            // 
            // drvSinhVien
            // 
            this.drvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.drvSinhVien.Location = new System.Drawing.Point(6, 25);
            this.drvSinhVien.Name = "drvSinhVien";
            this.drvSinhVien.RowHeadersWidth = 62;
            this.drvSinhVien.RowTemplate.Height = 28;
            this.drvSinhVien.Size = new System.Drawing.Size(910, 358);
            this.drvSinhVien.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Số Sinh Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Và Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tên Lớp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(184, 94);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(434, 26);
            this.txtHoTen.TabIndex = 3;
            // 
            // txtMASV
            // 
            this.txtMASV.Location = new System.Drawing.Point(184, 162);
            this.txtMASV.Name = "txtMASV";
            this.txtMASV.Size = new System.Drawing.Size(434, 26);
            this.txtMASV.TabIndex = 4;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(184, 226);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(434, 26);
            this.txtLop.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(517, 275);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 53);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(614, 275);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 53);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(711, 275);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 53);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(808, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 53);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmQuanLiSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 715);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtMASV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grbThongTIn);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLiSV";
            this.Text = "Quản Lí Sinh Viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLiSV_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLiSV_Load);
            this.grbThongTIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.drvSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTIn;
        private System.Windows.Forms.DataGridView drvSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMASV;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

