
namespace BTLWF
{
    partial class frmChuyenSinhHoatDoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChuyenSinhHoatDoan));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvChuyenSinhHoatDoan = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaCB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayChuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiChuyenDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtDonVi = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayNop = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbMaSV = new System.Windows.Forms.ComboBox();
            this.cbbMaCB = new System.Windows.Forms.ComboBox();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenSinhHoatDoan)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bunifuPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvChuyenSinhHoatDoan, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 440F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1239, 857);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvChuyenSinhHoatDoan
            // 
            this.dgvChuyenSinhHoatDoan.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvChuyenSinhHoatDoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChuyenSinhHoatDoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenSinhHoatDoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChuyenSinhHoatDoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dgvChuyenSinhHoatDoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.ForestGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvChuyenSinhHoatDoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvChuyenSinhHoatDoan.ColumnHeadersHeight = 40;
            this.dgvChuyenSinhHoatDoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.MaCB,
            this.NgayChuyen,
            this.NoiChuyenDen});
            this.dgvChuyenSinhHoatDoan.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(226)))), ((int)(((byte)(199)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChuyenSinhHoatDoan.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.BackColor = System.Drawing.Color.ForestGreen;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.ForestGreen;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvChuyenSinhHoatDoan.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(111)))), ((int)(((byte)(27)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.Name = null;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvChuyenSinhHoatDoan.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvChuyenSinhHoatDoan.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            this.dgvChuyenSinhHoatDoan.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(231)))), ((int)(((byte)(210)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(185)))), ((int)(((byte)(122)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChuyenSinhHoatDoan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvChuyenSinhHoatDoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuyenSinhHoatDoan.EnableHeadersVisualStyles = false;
            this.dgvChuyenSinhHoatDoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(220)))), ((int)(((byte)(188)))));
            this.dgvChuyenSinhHoatDoan.HeaderBackColor = System.Drawing.Color.ForestGreen;
            this.dgvChuyenSinhHoatDoan.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvChuyenSinhHoatDoan.HeaderForeColor = System.Drawing.Color.White;
            this.dgvChuyenSinhHoatDoan.Location = new System.Drawing.Point(3, 443);
            this.dgvChuyenSinhHoatDoan.Name = "dgvChuyenSinhHoatDoan";
            this.dgvChuyenSinhHoatDoan.RowHeadersVisible = false;
            this.dgvChuyenSinhHoatDoan.RowHeadersWidth = 62;
            this.dgvChuyenSinhHoatDoan.RowTemplate.Height = 40;
            this.dgvChuyenSinhHoatDoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChuyenSinhHoatDoan.Size = new System.Drawing.Size(1233, 411);
            this.dgvChuyenSinhHoatDoan.TabIndex = 1;
            this.dgvChuyenSinhHoatDoan.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.ForestGreen;
            this.dgvChuyenSinhHoatDoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChuyenSinhHoatDoan_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 8;
            this.MaSV.Name = "MaSV";
            // 
            // MaCB
            // 
            this.MaCB.DataPropertyName = "MaCB";
            this.MaCB.HeaderText = "Mã cán bộ";
            this.MaCB.MinimumWidth = 8;
            this.MaCB.Name = "MaCB";
            // 
            // NgayChuyen
            // 
            this.NgayChuyen.DataPropertyName = "NgayChuyen";
            this.NgayChuyen.HeaderText = "Ngày chuyển";
            this.NgayChuyen.MinimumWidth = 8;
            this.NgayChuyen.Name = "NgayChuyen";
            // 
            // NoiChuyenDen
            // 
            this.NoiChuyenDen.DataPropertyName = "NoiChuyenDen";
            this.NoiChuyenDen.HeaderText = "Đơn vị mới";
            this.NoiChuyenDen.MinimumWidth = 8;
            this.NoiChuyenDen.Name = "NoiChuyenDen";
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtDonVi);
            this.bunifuPanel1.Controls.Add(this.label2);
            this.bunifuPanel1.Controls.Add(this.dtNgayNop);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.cbbMaSV);
            this.bunifuPanel1.Controls.Add(this.cbbMaCB);
            this.bunifuPanel1.Controls.Add(this.btnXuat);
            this.bunifuPanel1.Controls.Add(this.btnTimKiem);
            this.bunifuPanel1.Controls.Add(this.btnThoat);
            this.bunifuPanel1.Controls.Add(this.btnSua);
            this.bunifuPanel1.Controls.Add(this.btnThem);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.label7);
            this.bunifuPanel1.Controls.Add(this.button2);
            this.bunifuPanel1.Controls.Add(this.label1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuPanel1.Location = new System.Drawing.Point(3, 3);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1233, 434);
            this.bunifuPanel1.TabIndex = 0;
            // 
            // txtDonVi
            // 
            this.txtDonVi.AcceptsReturn = false;
            this.txtDonVi.AcceptsTab = false;
            this.txtDonVi.AnimationSpeed = 200;
            this.txtDonVi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDonVi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDonVi.BackColor = System.Drawing.Color.Transparent;
            this.txtDonVi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtDonVi.BackgroundImage")));
            this.txtDonVi.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtDonVi.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDonVi.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtDonVi.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtDonVi.BorderRadius = 1;
            this.txtDonVi.BorderThickness = 1;
            this.txtDonVi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDonVi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDonVi.DefaultFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonVi.DefaultText = "";
            this.txtDonVi.FillColor = System.Drawing.Color.White;
            this.txtDonVi.HideSelection = true;
            this.txtDonVi.IconLeft = null;
            this.txtDonVi.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txtDonVi.IconPadding = 10;
            this.txtDonVi.IconRight = null;
            this.txtDonVi.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtDonVi.Lines = new string[0];
            this.txtDonVi.Location = new System.Drawing.Point(831, 257);
            this.txtDonVi.MaxLength = 32767;
            this.txtDonVi.MinimumSize = new System.Drawing.Size(2, 2);
            this.txtDonVi.Modified = false;
            this.txtDonVi.Multiline = false;
            this.txtDonVi.Name = "txtDonVi";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDonVi.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDonVi.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDonVi.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtDonVi.OnIdleState = stateProperties4;
            this.txtDonVi.Padding = new System.Windows.Forms.Padding(3);
            this.txtDonVi.PasswordChar = '\0';
            this.txtDonVi.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDonVi.PlaceholderText = "Đơn vị chuyển đến";
            this.txtDonVi.ReadOnly = false;
            this.txtDonVi.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtDonVi.SelectedText = "";
            this.txtDonVi.SelectionLength = 0;
            this.txtDonVi.SelectionStart = 0;
            this.txtDonVi.ShortcutsEnabled = true;
            this.txtDonVi.Size = new System.Drawing.Size(230, 40);
            this.txtDonVi.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtDonVi.TabIndex = 113;
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDonVi.TextMarginBottom = 0;
            this.txtDonVi.TextMarginLeft = 3;
            this.txtDonVi.TextMarginTop = 0;
            this.txtDonVi.TextPlaceholder = "Đơn vị chuyển đến";
            this.txtDonVi.UseSystemPasswordChar = false;
            this.txtDonVi.WordWrap = true;
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::BTLWF.Properties.Resources.icons8_marker_32;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(630, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 52);
            this.label2.TabIndex = 112;
            this.label2.Text = "Đơn vị mới";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtNgayNop
            // 
            this.dtNgayNop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtNgayNop.CustomFormat = "yyy-MM-dd";
            this.dtNgayNop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayNop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNop.Location = new System.Drawing.Point(831, 191);
            this.dtNgayNop.Name = "dtNgayNop";
            this.dtNgayNop.Size = new System.Drawing.Size(226, 31);
            this.dtNgayNop.TabIndex = 111;
            this.dtNgayNop.Value = new System.DateTime(2021, 8, 16, 14, 1, 39, 0);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::BTLWF.Properties.Resources.icons8_timeline_week_32;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(630, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 43);
            this.label4.TabIndex = 109;
            this.label4.Text = "Ngày chuyển";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbMaSV
            // 
            this.cbbMaSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMaSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSV.FormattingEnabled = true;
            this.cbbMaSV.Location = new System.Drawing.Point(357, 191);
            this.cbbMaSV.Name = "cbbMaSV";
            this.cbbMaSV.Size = new System.Drawing.Size(226, 33);
            this.cbbMaSV.TabIndex = 106;
            // 
            // cbbMaCB
            // 
            this.cbbMaCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbMaCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaCB.FormattingEnabled = true;
            this.cbbMaCB.Location = new System.Drawing.Point(357, 257);
            this.cbbMaCB.Name = "cbbMaCB";
            this.cbbMaCB.Size = new System.Drawing.Size(226, 33);
            this.cbbMaCB.TabIndex = 104;
            // 
            // btnXuat
            // 
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuat.Location = new System.Drawing.Point(738, 338);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(128, 65);
            this.btnXuat.TabIndex = 103;
            this.btnXuat.Text = "Xuất file";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuat.UseVisualStyleBackColor = true;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(582, 338);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(136, 65);
            this.btnTimKiem.TabIndex = 102;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(886, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 65);
            this.btnThoat.TabIndex = 98;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(429, 338);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 65);
            this.btnSua.TabIndex = 100;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Gainsboro;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FloralWhite;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(267, 338);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 65);
            this.btnThem.TabIndex = 101;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::BTLWF.Properties.Resources.icons8_student_male_32;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(176, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 52);
            this.label5.TabIndex = 96;
            this.label5.Text = "Mã sinh viên";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::BTLWF.Properties.Resources.icons8_orcid_321;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(174, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 52);
            this.label7.TabIndex = 97;
            this.label7.Text = "Mã cán bộ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(580, 57);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(303, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 45);
            this.label1.TabIndex = 21;
            this.label1.Text = "THÔNG TIN CHUYỂN SINH HOẠT ĐOÀN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChuyenSinhHoatDoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 857);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmChuyenSinhHoatDoan";
            this.Text = "Thông tin chuyển sinh hoạt Đoàn";
            this.Load += new System.EventHandler(this.frmChuyenSinhHoatDoan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenSinhHoatDoan)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox txtDonVi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayNop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbMaSV;
        private System.Windows.Forms.ComboBox cbbMaCB;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvChuyenSinhHoatDoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayChuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiChuyenDen;
    }
}