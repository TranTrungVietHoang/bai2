namespace lab2_02
{
    partial class FrmQLSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbChuyenNganh = new System.Windows.Forms.ComboBox();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lbChuyenNganh = new System.Windows.Forms.Label();
            this.lbDTB = new System.Windows.Forms.Label();
            this.lbGioiTinh = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.dgvMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSLNam = new System.Windows.Forms.TextBox();
            this.txtSLNu = new System.Windows.Forms.TextBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbChuyenNganh);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.txtDTB);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.lbChuyenNganh);
            this.groupBox1.Controls.Add(this.lbDTB);
            this.groupBox1.Controls.Add(this.lbGioiTinh);
            this.groupBox1.Controls.Add(this.lbHoTen);
            this.groupBox1.Controls.Add(this.lbMSSV);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmbChuyenNganh
            // 
            this.cmbChuyenNganh.FormattingEnabled = true;
            this.cmbChuyenNganh.Items.AddRange(new object[] {
            "CNTT",
            "QTKD",
            "NNA"});
            this.cmbChuyenNganh.Location = new System.Drawing.Point(125, 274);
            this.cmbChuyenNganh.Name = "cmbChuyenNganh";
            this.cmbChuyenNganh.Size = new System.Drawing.Size(191, 26);
            this.cmbChuyenNganh.TabIndex = 10;
            this.cmbChuyenNganh.SelectedIndexChanged += new System.EventHandler(this.cmbChuyenNganh_SelectedIndexChanged);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(216, 155);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(45, 22);
            this.rbNu.TabIndex = 9;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nu";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(125, 155);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 22);
            this.rbNam.TabIndex = 8;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(125, 208);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(191, 24);
            this.txtDTB.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(125, 100);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(191, 24);
            this.txtHoTen.TabIndex = 6;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(125, 46);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(191, 24);
            this.txtMSSV.TabIndex = 5;
            // 
            // lbChuyenNganh
            // 
            this.lbChuyenNganh.AutoSize = true;
            this.lbChuyenNganh.Location = new System.Drawing.Point(6, 274);
            this.lbChuyenNganh.Name = "lbChuyenNganh";
            this.lbChuyenNganh.Size = new System.Drawing.Size(105, 18);
            this.lbChuyenNganh.TabIndex = 4;
            this.lbChuyenNganh.Text = "Chuyen Nganh";
            // 
            // lbDTB
            // 
            this.lbDTB.AutoSize = true;
            this.lbDTB.Location = new System.Drawing.Point(6, 211);
            this.lbDTB.Name = "lbDTB";
            this.lbDTB.Size = new System.Drawing.Size(38, 18);
            this.lbDTB.TabIndex = 3;
            this.lbDTB.Text = "DTB";
            // 
            // lbGioiTinh
            // 
            this.lbGioiTinh.AutoSize = true;
            this.lbGioiTinh.Location = new System.Drawing.Point(6, 155);
            this.lbGioiTinh.Name = "lbGioiTinh";
            this.lbGioiTinh.Size = new System.Drawing.Size(67, 18);
            this.lbGioiTinh.TabIndex = 2;
            this.lbGioiTinh.Text = "Gioi Tinh";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoTen.Location = new System.Drawing.Point(6, 106);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(52, 16);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "Ho Ten";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMSSV.Location = new System.Drawing.Point(6, 46);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(45, 16);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "MSSV";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMSSV,
            this.dgvHoTen,
            this.dgvGioiTinh,
            this.dgvDTB,
            this.dgvKhoa});
            this.dgvStudent.Location = new System.Drawing.Point(361, 62);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(640, 401);
            this.dgvStudent.TabIndex = 1;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // dgvMSSV
            // 
            this.dgvMSSV.HeaderText = "MSSV";
            this.dgvMSSV.Name = "dgvMSSV";
            this.dgvMSSV.Width = 120;
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Ho Ten";
            this.dgvHoTen.Name = "dgvHoTen";
            this.dgvHoTen.Width = 175;
            // 
            // dgvGioiTinh
            // 
            this.dgvGioiTinh.HeaderText = "Gioi Tinh";
            this.dgvGioiTinh.Name = "dgvGioiTinh";
            // 
            // dgvDTB
            // 
            this.dgvDTB.HeaderText = "DTB";
            this.dgvDTB.Name = "dgvDTB";
            // 
            // dgvKhoa
            // 
            this.dgvKhoa.HeaderText = "Khoa";
            this.dgvKhoa.Name = "dgvKhoa";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(176, 426);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 39);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(38, 426);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 39);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Them / Sua";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(668, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(860, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nu";
            // 
            // txtSLNam
            // 
            this.txtSLNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNam.Location = new System.Drawing.Point(718, 469);
            this.txtSLNam.Name = "txtSLNam";
            this.txtSLNam.ReadOnly = true;
            this.txtSLNam.Size = new System.Drawing.Size(100, 22);
            this.txtSLNam.TabIndex = 7;
            // 
            // txtSLNu
            // 
            this.txtSLNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLNu.Location = new System.Drawing.Point(890, 469);
            this.txtSLNu.Name = "txtSLNu";
            this.txtSLNu.ReadOnly = true;
            this.txtSLNu.Size = new System.Drawing.Size(100, 22);
            this.txtSLNu.TabIndex = 8;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 567);
            this.Controls.Add(this.txtSLNu);
            this.Controls.Add(this.txtSLNam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmQLSV";
            this.Text = "FrmQLSV";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQLSV_FormClosing);
            this.Load += new System.EventHandler(this.FrmQLSV_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lbChuyenNganh;
        private System.Windows.Forms.Label lbDTB;
        private System.Windows.Forms.Label lbGioiTinh;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.ComboBox cmbChuyenNganh;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKhoa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSLNam;
        private System.Windows.Forms.TextBox txtSLNu;
        private System.Windows.Forms.ErrorProvider err;
    }
}

