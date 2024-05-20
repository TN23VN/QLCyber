namespace QLCyber
{
    partial class frTaiKhoan
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_addTK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_mon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_timmon = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_body = new System.Windows.Forms.Panel();
            this.quanNetDataSet1 = new QLCyber.QuanNetDataSet1();
            this.tbltaikhoankhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_taikhoankhachTableAdapter = new QLCyber.QuanNetDataSet1TableAdapters.tbl_taikhoankhachTableAdapter();
            this.tenTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenChuTKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCCDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaikhoankhachBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_addTK);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 72);
            this.panel4.TabIndex = 0;
            // 
            // btn_addTK
            // 
            this.btn_addTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_addTK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTK.Location = new System.Drawing.Point(0, 0);
            this.btn_addTK.Name = "btn_addTK";
            this.btn_addTK.Size = new System.Drawing.Size(162, 70);
            this.btn_addTK.TabIndex = 0;
            this.btn_addTK.Text = "Thêm Tài Khoản";
            this.btn_addTK.UseVisualStyleBackColor = false;
            this.btn_addTK.Click += new System.EventHandler(this.btn_addTK_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(162, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sửa Tài Khoản";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xoá Tài Khoản";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(486, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Nạp Tiền";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(648, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "Lịch sử";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 90);
            this.panel1.TabIndex = 3;
            // 
            // tb_mon
            // 
            this.tb_mon.AllowUserToAddRows = false;
            this.tb_mon.AllowUserToDeleteRows = false;
            this.tb_mon.AllowUserToResizeColumns = false;
            this.tb_mon.AllowUserToResizeRows = false;
            this.tb_mon.AutoGenerateColumns = false;
            this.tb_mon.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tb_mon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_mon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenTKDataGridViewTextBoxColumn,
            this.matKhauDataGridViewTextBoxColumn,
            this.tienTKDataGridViewTextBoxColumn,
            this.tenChuTKDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.cCCDDataGridViewTextBoxColumn});
            this.tb_mon.DataSource = this.tbltaikhoankhachBindingSource;
            this.tb_mon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.tb_mon.Location = new System.Drawing.Point(13, 43);
            this.tb_mon.Name = "tb_mon";
            this.tb_mon.ReadOnly = true;
            this.tb_mon.RowHeadersVisible = false;
            this.tb_mon.RowHeadersWidth = 51;
            this.tb_mon.RowTemplate.Height = 24;
            this.tb_mon.Size = new System.Drawing.Size(541, 422);
            this.tb_mon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txt_timmon
            // 
            this.txt_timmon.Location = new System.Drawing.Point(84, 6);
            this.txt_timmon.Name = "txt_timmon";
            this.txt_timmon.Size = new System.Drawing.Size(461, 22);
            this.txt_timmon.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.txt_timmon);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tb_mon);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 475);
            this.panel2.TabIndex = 4;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(560, 90);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(285, 475);
            this.panel_body.TabIndex = 5;
            // 
            // quanNetDataSet1
            // 
            this.quanNetDataSet1.DataSetName = "QuanNetDataSet1";
            this.quanNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbltaikhoankhachBindingSource
            // 
            this.tbltaikhoankhachBindingSource.DataMember = "tbl_taikhoankhach";
            this.tbltaikhoankhachBindingSource.DataSource = this.quanNetDataSet1;
            // 
            // tbl_taikhoankhachTableAdapter
            // 
            this.tbl_taikhoankhachTableAdapter.ClearBeforeFill = true;
            // 
            // tenTKDataGridViewTextBoxColumn
            // 
            this.tenTKDataGridViewTextBoxColumn.DataPropertyName = "TenTK";
            this.tenTKDataGridViewTextBoxColumn.HeaderText = "TenTK";
            this.tenTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenTKDataGridViewTextBoxColumn.Name = "tenTKDataGridViewTextBoxColumn";
            this.tenTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // matKhauDataGridViewTextBoxColumn
            // 
            this.matKhauDataGridViewTextBoxColumn.DataPropertyName = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.HeaderText = "MatKhau";
            this.matKhauDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.matKhauDataGridViewTextBoxColumn.Name = "matKhauDataGridViewTextBoxColumn";
            this.matKhauDataGridViewTextBoxColumn.ReadOnly = true;
            this.matKhauDataGridViewTextBoxColumn.Width = 125;
            // 
            // tienTKDataGridViewTextBoxColumn
            // 
            this.tienTKDataGridViewTextBoxColumn.DataPropertyName = "TienTK";
            this.tienTKDataGridViewTextBoxColumn.HeaderText = "TienTK";
            this.tienTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tienTKDataGridViewTextBoxColumn.Name = "tienTKDataGridViewTextBoxColumn";
            this.tienTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tienTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenChuTKDataGridViewTextBoxColumn
            // 
            this.tenChuTKDataGridViewTextBoxColumn.DataPropertyName = "TenChuTK";
            this.tenChuTKDataGridViewTextBoxColumn.HeaderText = "TenChuTK";
            this.tenChuTKDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenChuTKDataGridViewTextBoxColumn.Name = "tenChuTKDataGridViewTextBoxColumn";
            this.tenChuTKDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenChuTKDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.ReadOnly = true;
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cCCDDataGridViewTextBoxColumn
            // 
            this.cCCDDataGridViewTextBoxColumn.DataPropertyName = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.HeaderText = "CCCD";
            this.cCCDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cCCDDataGridViewTextBoxColumn.Name = "cCCDDataGridViewTextBoxColumn";
            this.cCCDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCCDDataGridViewTextBoxColumn.Width = 125;
            // 
            // frTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 565);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frTaiKhoan";
            this.Text = "frTaiKhoan";
            this.Load += new System.EventHandler(this.frTaiKhoan_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_mon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaikhoankhachBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addTK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tb_mon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_timmon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private QuanNetDataSet1 quanNetDataSet1;
        private System.Windows.Forms.BindingSource tbltaikhoankhachBindingSource;
        private QuanNetDataSet1TableAdapters.tbl_taikhoankhachTableAdapter tbl_taikhoankhachTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenChuTKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCCDDataGridViewTextBoxColumn;
    }
}