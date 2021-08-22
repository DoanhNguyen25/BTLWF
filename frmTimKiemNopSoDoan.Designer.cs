
namespace BTLWF
{
    partial class frmTimKiemNopSoDoan
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
            this.cbbMasv = new System.Windows.Forms.ComboBox();
            this.btnTimKiemTheoMa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbMacb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMasvMacb = new System.Windows.Forms.Button();
            this.dgvThongTinTimKiem = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHeader = new System.Windows.Forms.Label();
            this.btnMaCB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbMasv
            // 
            this.cbbMasv.FormattingEnabled = true;
            this.cbbMasv.Location = new System.Drawing.Point(384, 70);
            this.cbbMasv.Name = "cbbMasv";
            this.cbbMasv.Size = new System.Drawing.Size(239, 28);
            this.cbbMasv.TabIndex = 0;
            // 
            // btnTimKiemTheoMa
            // 
            this.btnTimKiemTheoMa.Location = new System.Drawing.Point(227, 220);
            this.btnTimKiemTheoMa.Name = "btnTimKiemTheoMa";
            this.btnTimKiemTheoMa.Size = new System.Drawing.Size(217, 63);
            this.btnTimKiemTheoMa.TabIndex = 2;
            this.btnTimKiemTheoMa.Text = "Tìm kiếm theo MaSV";
            this.btnTimKiemTheoMa.UseVisualStyleBackColor = true;
            this.btnTimKiemTheoMa.Click += new System.EventHandler(this.btnTimKiemTheoMa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Sinh Vien";
            // 
            // cbbMacb
            // 
            this.cbbMacb.FormattingEnabled = true;
            this.cbbMacb.Location = new System.Drawing.Point(384, 129);
            this.cbbMacb.Name = "cbbMacb";
            this.cbbMacb.Size = new System.Drawing.Size(239, 28);
            this.cbbMacb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã cán bộ";
            // 
            // btnMasvMacb
            // 
            this.btnMasvMacb.Location = new System.Drawing.Point(384, 305);
            this.btnMasvMacb.Name = "btnMasvMacb";
            this.btnMasvMacb.Size = new System.Drawing.Size(244, 63);
            this.btnMasvMacb.TabIndex = 2;
            this.btnMasvMacb.Text = "Tìm kiếm theo MaSV+MaCB";
            this.btnMasvMacb.UseVisualStyleBackColor = true;
            this.btnMasvMacb.Click += new System.EventHandler(this.btnMasvMacb_Click);
            // 
            // dgvThongTinTimKiem
            // 
            this.dgvThongTinTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaCB,
            this.SoSD,
            this.NgayNop});
            this.dgvThongTinTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvThongTinTimKiem.Location = new System.Drawing.Point(0, 447);
            this.dgvThongTinTimKiem.Name = "dgvThongTinTimKiem";
            this.dgvThongTinTimKiem.RowHeadersWidth = 62;
            this.dgvThongTinTimKiem.RowTemplate.Height = 28;
            this.dgvThongTinTimKiem.Size = new System.Drawing.Size(1033, 150);
            this.dgvThongTinTimKiem.TabIndex = 4;
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
            // SoSD
            // 
            this.SoSD.DataPropertyName = "SoSD";
            this.SoSD.HeaderText = "Số sổ đoàn";
            this.SoSD.MinimumWidth = 8;
            this.SoSD.Name = "SoSD";
            this.SoSD.Width = 150;
            // 
            // NgayNop
            // 
            this.NgayNop.DataPropertyName = "NgayNop";
            this.NgayNop.HeaderText = "Ngày nộp";
            this.NgayNop.MinimumWidth = 8;
            this.NgayNop.Name = "NgayNop";
            this.NgayNop.Width = 150;
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(140, 396);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(565, 33);
            this.txtHeader.TabIndex = 5;
            this.txtHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMaCB
            // 
            this.btnMaCB.Location = new System.Drawing.Point(580, 220);
            this.btnMaCB.Name = "btnMaCB";
            this.btnMaCB.Size = new System.Drawing.Size(200, 60);
            this.btnMaCB.TabIndex = 6;
            this.btnMaCB.Text = "Tìm kiếm theo MaCB";
            this.btnMaCB.UseVisualStyleBackColor = true;
            this.btnMaCB.Click += new System.EventHandler(this.btnMaCB_Click);
            // 
            // frmTimKiemNopSoDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.btnMaCB);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.dgvThongTinTimKiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbMacb);
            this.Controls.Add(this.btnMasvMacb);
            this.Controls.Add(this.btnTimKiemTheoMa);
            this.Controls.Add(this.cbbMasv);
            this.Name = "frmTimKiemNopSoDoan";
            this.Text = "frmTimKiemNopSoDoan";
            this.Load += new System.EventHandler(this.frmTimKiemNopSoDoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbMasv;
        private System.Windows.Forms.Button btnTimKiemTheoMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbMacb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMasvMacb;
        private System.Windows.Forms.DataGridView dgvThongTinTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNop;
        private System.Windows.Forms.Label txtHeader;
        private System.Windows.Forms.Button btnMaCB;
    }
}