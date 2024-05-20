namespace QLCyber
{
    partial class frDichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addFood = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_timmon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_mon = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenmonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giabanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblmonanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanNetDataSet = new QLCyber.QuanNetDataSet();
            this.panel_body = new System.Windows.Forms.Panel();
            this.tbl_monanTableAdapter = new QLCyber.QuanNetDataSetTableAdapters.tbl_monanTableAdapter();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 90);
            this.panel1.TabIndex = 0;
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
            this.panel4.Controls.Add(this.btn_addFood);
            this.panel4.Location = new System.Drawing.Point(13, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(818, 72);
            this.panel4.TabIndex = 0;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(486, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "Gọi Món";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button2.Text = "Xoá Món";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.button1.Text = "Sửa Món";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addFood
            // 
            this.btn_addFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_addFood.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addFood.Location = new System.Drawing.Point(0, 0);
            this.btn_addFood.Name = "btn_addFood";
            this.btn_addFood.Size = new System.Drawing.Size(162, 70);
            this.btn_addFood.TabIndex = 0;
            this.btn_addFood.Text = "Thêm Món";
            this.btn_addFood.UseVisualStyleBackColor = false;
            this.btn_addFood.Click += new System.EventHandler(this.btn_addFood_Click);
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
            this.panel2.Size = new System.Drawing.Size(560, 471);
            this.panel2.TabIndex = 1;
            // 
            // txt_timmon
            // 
            this.txt_timmon.Location = new System.Drawing.Point(84, 6);
            this.txt_timmon.Name = "txt_timmon";
            this.txt_timmon.Size = new System.Drawing.Size(461, 22);
            this.txt_timmon.TabIndex = 2;
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
            this.iDDataGridViewTextBoxColumn,
            this.tenmonDataGridViewTextBoxColumn,
            this.giabanDataGridViewTextBoxColumn});
            this.tb_mon.DataSource = this.tblmonanBindingSource;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 41;
            // 
            // tenmonDataGridViewTextBoxColumn
            // 
            this.tenmonDataGridViewTextBoxColumn.DataPropertyName = "tenmon";
            this.tenmonDataGridViewTextBoxColumn.HeaderText = "Tên món";
            this.tenmonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenmonDataGridViewTextBoxColumn.Name = "tenmonDataGridViewTextBoxColumn";
            this.tenmonDataGridViewTextBoxColumn.ReadOnly = true;
            this.tenmonDataGridViewTextBoxColumn.Width = 300;
            // 
            // giabanDataGridViewTextBoxColumn
            // 
            this.giabanDataGridViewTextBoxColumn.DataPropertyName = "giaban";
            this.giabanDataGridViewTextBoxColumn.HeaderText = "Giá bán";
            this.giabanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giabanDataGridViewTextBoxColumn.Name = "giabanDataGridViewTextBoxColumn";
            this.giabanDataGridViewTextBoxColumn.ReadOnly = true;
            this.giabanDataGridViewTextBoxColumn.Width = 200;
            // 
            // tblmonanBindingSource
            // 
            this.tblmonanBindingSource.DataMember = "tbl_monan";
            this.tblmonanBindingSource.DataSource = this.quanNetDataSet;
            // 
            // quanNetDataSet
            // 
            this.quanNetDataSet.DataSetName = "QuanNetDataSet";
            this.quanNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_body.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(560, 90);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(283, 471);
            this.panel_body.TabIndex = 2;
            // 
            // tbl_monanTableAdapter
            // 
            this.tbl_monanTableAdapter.ClearBeforeFill = true;
            // 
            // frDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 561);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frDichVu";
            this.Text = "frDichVu";
            this.Load += new System.EventHandler(this.frDichVu_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_mon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tb_mon;
        private QuanNetDataSet quanNetDataSet;
        private System.Windows.Forms.BindingSource tblmonanBindingSource;
        private QuanNetDataSetTableAdapters.tbl_monanTableAdapter tbl_monanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giabanDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_addFood;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_timmon;
        private System.Windows.Forms.Label label1;
    }
}