
namespace BTLWF
{
    partial class TimKiemCBDoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimKiemCBDoan));
            this.btnMaCB = new System.Windows.Forms.Button();
            this.btnMaHD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMaCB
            // 
            this.btnMaCB.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaCB.Location = new System.Drawing.Point(150, 169);
            this.btnMaCB.Name = "btnMaCB";
            this.btnMaCB.Size = new System.Drawing.Size(196, 85);
            this.btnMaCB.TabIndex = 0;
            this.btnMaCB.Text = "Mã cán bộ";
            this.btnMaCB.UseVisualStyleBackColor = true;
            this.btnMaCB.Click += new System.EventHandler(this.btnMaCB_Click);
            // 
            // btnMaHD
            // 
            this.btnMaHD.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHD.Location = new System.Drawing.Point(457, 169);
            this.btnMaHD.Name = "btnMaHD";
            this.btnMaHD.Size = new System.Drawing.Size(196, 85);
            this.btnMaHD.TabIndex = 0;
            this.btnMaHD.Text = "Mã hoạt động";
            this.btnMaHD.UseVisualStyleBackColor = true;
            this.btnMaHD.Click += new System.EventHandler(this.btnMaHD_Click);
            // 
            // TimKiemCBDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaHD);
            this.Controls.Add(this.btnMaCB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimKiemCBDoan";
            this.Text = "Tìm kiếm cán bộ Đoàn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMaCB;
        private System.Windows.Forms.Button btnMaHD;
    }
}