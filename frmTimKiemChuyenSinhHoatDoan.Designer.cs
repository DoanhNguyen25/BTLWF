
namespace BTLWF
{
    partial class frmTimKiemChuyenSinhHoatDoan
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.cbbMaCB = new System.Windows.Forms.ComboBox();
            this.btnMasv = new System.Windows.Forms.Button();
            this.btnMacb = new System.Windows.Forms.Button();
            this.btnMasv_MaCB = new System.Windows.Forms.Button();
            this.lblheader = new System.Windows.Forms.Label();
            this.dgvTimChuyenSinhHoatDoan = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiChuyenDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimChuyenSinhHoatDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã cán bộ";
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(177, 71);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(172, 28);
            this.cbbMaSV.TabIndex = 1;
            // 
            // cbbMaCB
            // 
            this.cbbMaCB.FormattingEnabled = true;
            this.cbbMaCB.Location = new System.Drawing.Point(608, 71);
            this.cbbMaCB.Name = "cbbMaCB";
            this.cbbMaCB.Size = new System.Drawing.Size(166, 28);
            this.cbbMaCB.TabIndex = 1;
            // 
            // btnMasv
            // 
            this.btnMasv.Location = new System.Drawing.Point(118, 157);
            this.btnMasv.Name = "btnMasv";
            this.btnMasv.Size = new System.Drawing.Size(166, 47);
            this.btnMasv.TabIndex = 2;
            this.btnMasv.Text = "Tìm kiếm theo masv";
            this.btnMasv.UseVisualStyleBackColor = true;
            this.btnMasv.Click += new System.EventHandler(this.btnMasv_Click);
            // 
            // btnMacb
            // 
            this.btnMacb.Location = new System.Drawing.Point(504, 157);
            this.btnMacb.Name = "btnMacb";
            this.btnMacb.Size = new System.Drawing.Size(202, 47);
            this.btnMacb.TabIndex = 2;
            this.btnMacb.Text = "Tìm kiếm theo MaCB";
            this.btnMacb.UseVisualStyleBackColor = true;
            this.btnMacb.Click += new System.EventHandler(this.btnMacb_Click);
            // 
            // btnMasv_MaCB
            // 
            this.btnMasv_MaCB.Location = new System.Drawing.Point(271, 240);
            this.btnMasv_MaCB.Name = "btnMasv_MaCB";
            this.btnMasv_MaCB.Size = new System.Drawing.Size(266, 42);
            this.btnMasv_MaCB.TabIndex = 3;
            this.btnMasv_MaCB.Text = "Tìm kiếm theo MaSV_MaCB";
            this.btnMasv_MaCB.UseVisualStyleBackColor = true;
            this.btnMasv_MaCB.Click += new System.EventHandler(this.btnMasv_MaCB_Click);
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Location = new System.Drawing.Point(338, 343);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(0, 20);
            this.lblheader.TabIndex = 4;
            this.lblheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTimChuyenSinhHoatDoan
            // 
            this.dgvTimChuyenSinhHoatDoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimChuyenSinhHoatDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaCB,
            this.NgayChuyen,
            this.NoiChuyenDen});
            this.dgvTimChuyenSinhHoatDoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTimChuyenSinhHoatDoan.Location = new System.Drawing.Point(0, 459);
            this.dgvTimChuyenSinhHoatDoan.Name = "dgvTimChuyenSinhHoatDoan";
            this.dgvTimChuyenSinhHoatDoan.RowHeadersWidth = 62;
            this.dgvTimChuyenSinhHoatDoan.RowTemplate.Height = 28;
            this.dgvTimChuyenSinhHoatDoan.Size = new System.Drawing.Size(800, 150);
            this.dgvTimChuyenSinhHoatDoan.TabIndex = 5;
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 150;
            // 
            // MaCB
            // 
            this.MaCB.DataPropertyName = "MaCB";
            this.MaCB.HeaderText = "Mã cán bộ";
            this.MaCB.MinimumWidth = 8;
            this.MaCB.Name = "MaCB";
            this.MaCB.Width = 150;
            // 
            // NgayChuyen
            // 
            this.NgayChuyen.DataPropertyName = "NgayChuyen";
            this.NgayChuyen.HeaderText = "Ngày chuyển";
            this.NgayChuyen.MinimumWidth = 8;
            this.NgayChuyen.Name = "NgayChuyen";
            this.NgayChuyen.Width = 150;
            // 
            // NoiChuyenDen
            // 
            this.NoiChuyenDen.DataPropertyName = "NoiChuyenDen";
            this.NoiChuyenDen.HeaderText = "Nơi chuyển đến";
            this.NoiChuyenDen.MinimumWidth = 8;
            this.NoiChuyenDen.Name = "NoiChuyenDen";
            this.NoiChuyenDen.Width = 150;
            // 
            // frmTimKiemChuyenSinhHoatDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.Controls.Add(this.dgvTimChuyenSinhHoatDoan);
            this.Controls.Add(this.lblheader);
            this.Controls.Add(this.btnMasv_MaCB);
            this.Controls.Add(this.btnMacb);
            this.Controls.Add(this.btnMasv);
            this.Controls.Add(this.cbbMaCB);
            this.Controls.Add(this.cbbMaSV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimKiemChuyenSinhHoatDoan";
            this.Text = "frmTimKiemChuyenSinhHoatDoan";
            this.Load += new System.EventHandler(this.frmTimKiemChuyenSinhHoatDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimChuyenSinhHoatDoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.ComboBox cbbMaCB;
        private System.Windows.Forms.Button btnMasv;
        private System.Windows.Forms.Button btnMacb;
        private System.Windows.Forms.Button btnMasv_MaCB;
        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.DataGridView dgvTimChuyenSinhHoatDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiChuyenDen;
    }
}