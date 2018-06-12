namespace OnThi
{
    partial class DanhSachSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_DanhMuc = new System.Windows.Forms.ComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.btn_capNhat = new System.Windows.Forms.Button();
            this.lbl_slsp = new System.Windows.Forms.Label();
            this.lbl_masp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Des = new System.Windows.Forms.TextBox();
            this.btn_xembc = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.col_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_CatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ProStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_tblCat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_check,
            this.col_ProID,
            this.col_ProName,
            this.col_ProDescription,
            this.col_CatID,
            this.col_ProStatus,
            this.col_tblCat});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(780, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh Mục";
            // 
            // cbo_DanhMuc
            // 
            this.cbo_DanhMuc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_DanhMuc.FormattingEnabled = true;
            this.cbo_DanhMuc.Location = new System.Drawing.Point(233, 12);
            this.cbo_DanhMuc.Name = "cbo_DanhMuc";
            this.cbo_DanhMuc.Size = new System.Drawing.Size(201, 33);
            this.cbo_DanhMuc.TabIndex = 2;
            this.cbo_DanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbo_DanhMuc_SelectedIndexChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(233, 101);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(513, 33);
            this.txt_Name.TabIndex = 3;
            // 
            // btn_capNhat
            // 
            this.btn_capNhat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capNhat.Location = new System.Drawing.Point(405, 193);
            this.btn_capNhat.Name = "btn_capNhat";
            this.btn_capNhat.Size = new System.Drawing.Size(102, 37);
            this.btn_capNhat.TabIndex = 4;
            this.btn_capNhat.Text = "Cập nhật";
            this.btn_capNhat.UseVisualStyleBackColor = true;
            this.btn_capNhat.Click += new System.EventHandler(this.btn_capNhat_Click);
            // 
            // lbl_slsp
            // 
            this.lbl_slsp.AutoSize = true;
            this.lbl_slsp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_slsp.Location = new System.Drawing.Point(228, 239);
            this.lbl_slsp.Name = "lbl_slsp";
            this.lbl_slsp.Size = new System.Drawing.Size(66, 25);
            this.lbl_slsp.TabIndex = 6;
            this.lbl_slsp.Text = "label3";
            // 
            // lbl_masp
            // 
            this.lbl_masp.AutoSize = true;
            this.lbl_masp.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_masp.Location = new System.Drawing.Point(229, 61);
            this.lbl_masp.Name = "lbl_masp";
            this.lbl_masp.Size = new System.Drawing.Size(66, 25);
            this.lbl_masp.TabIndex = 7;
            this.lbl_masp.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Số Lượng sản phẩm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Danh sách";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mô tả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Mã sản phẩm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Tên sản phẩm";
            // 
            // txt_Des
            // 
            this.txt_Des.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Des.Location = new System.Drawing.Point(233, 150);
            this.txt_Des.Name = "txt_Des";
            this.txt_Des.Size = new System.Drawing.Size(513, 33);
            this.txt_Des.TabIndex = 13;
            // 
            // btn_xembc
            // 
            this.btn_xembc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xembc.Location = new System.Drawing.Point(305, 239);
            this.btn_xembc.Name = "btn_xembc";
            this.btn_xembc.Size = new System.Drawing.Size(283, 42);
            this.btn_xembc.TabIndex = 14;
            this.btn_xembc.Text = "Xem báo cáo";
            this.btn_xembc.UseVisualStyleBackColor = true;
            this.btn_xembc.Click += new System.EventHandler(this.btn_xembc_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(513, 193);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 37);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(305, 193);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(94, 37);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // col_check
            // 
            this.col_check.Frozen = true;
            this.col_check.HeaderText = "Check";
            this.col_check.Name = "col_check";
            this.col_check.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_check.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_check.Width = 70;
            // 
            // col_ProID
            // 
            this.col_ProID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProID.DataPropertyName = "ProID";
            this.col_ProID.Frozen = true;
            this.col_ProID.HeaderText = "ProID";
            this.col_ProID.Name = "col_ProID";
            this.col_ProID.ReadOnly = true;
            this.col_ProID.Width = 90;
            // 
            // col_ProName
            // 
            this.col_ProName.DataPropertyName = "ProName";
            this.col_ProName.Frozen = true;
            this.col_ProName.HeaderText = "ProName";
            this.col_ProName.Name = "col_ProName";
            this.col_ProName.ReadOnly = true;
            this.col_ProName.Width = 150;
            // 
            // col_ProDescription
            // 
            this.col_ProDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_ProDescription.DataPropertyName = "ProDescription";
            this.col_ProDescription.Frozen = true;
            this.col_ProDescription.HeaderText = "ProDescription";
            this.col_ProDescription.Name = "col_ProDescription";
            this.col_ProDescription.ReadOnly = true;
            this.col_ProDescription.Width = 476;
            // 
            // col_CatID
            // 
            this.col_CatID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.col_CatID.DataPropertyName = "CatID";
            this.col_CatID.Frozen = true;
            this.col_CatID.HeaderText = "CatID";
            this.col_CatID.Name = "col_CatID";
            this.col_CatID.ReadOnly = true;
            this.col_CatID.Width = 70;
            // 
            // col_ProStatus
            // 
            this.col_ProStatus.DataPropertyName = "ProStatus";
            this.col_ProStatus.Frozen = true;
            this.col_ProStatus.HeaderText = "ProStatus";
            this.col_ProStatus.Name = "col_ProStatus";
            this.col_ProStatus.ReadOnly = true;
            this.col_ProStatus.Visible = false;
            // 
            // col_tblCat
            // 
            this.col_tblCat.DataPropertyName = "tblCat";
            this.col_tblCat.Frozen = true;
            this.col_tblCat.HeaderText = "tblCat";
            this.col_tblCat.Name = "col_tblCat";
            this.col_tblCat.ReadOnly = true;
            this.col_tblCat.Visible = false;
            // 
            // DanhSachSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 494);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_xembc);
            this.Controls.Add(this.txt_Des);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_masp);
            this.Controls.Add(this.lbl_slsp);
            this.Controls.Add(this.btn_capNhat);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.cbo_DanhMuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DanhSachSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DanhSachSV";
            this.Load += new System.EventHandler(this.DanhSachSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_DanhMuc;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Button btn_capNhat;
        private System.Windows.Forms.Label lbl_slsp;
        private System.Windows.Forms.Label lbl_masp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Des;
        private System.Windows.Forms.Button btn_xembc;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_CatID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ProStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_tblCat;
    }
}