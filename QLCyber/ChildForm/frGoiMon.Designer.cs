namespace QLCyber
{
    partial class frGoiMon
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
            this.panel_goimon = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sl = new System.Windows.Forms.NumericUpDown();
            this.btn_dy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblmonanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanNetDataSet = new QLCyber.QuanNetDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.lvOder = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tenmon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.giamon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tongtt = new System.Windows.Forms.Label();
            this.tbl_monanTableAdapter = new QLCyber.QuanNetDataSetTableAdapters.tbl_monanTableAdapter();
            this.panel_goimon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_goimon
            // 
            this.panel_goimon.BackColor = System.Drawing.SystemColors.Control;
            this.panel_goimon.Controls.Add(this.label1);
            this.panel_goimon.Controls.Add(this.button7);
            this.panel_goimon.Controls.Add(this.button8);
            this.panel_goimon.Controls.Add(this.button6);
            this.panel_goimon.Controls.Add(this.label3);
            this.panel_goimon.Controls.Add(this.sl);
            this.panel_goimon.Controls.Add(this.btn_dy);
            this.panel_goimon.Controls.Add(this.comboBox1);
            this.panel_goimon.Controls.Add(this.label2);
            this.panel_goimon.Controls.Add(this.lvOder);
            this.panel_goimon.Controls.Add(this.panel1);
            this.panel_goimon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_goimon.Location = new System.Drawing.Point(0, 0);
            this.panel_goimon.Name = "panel_goimon";
            this.panel_goimon.Size = new System.Drawing.Size(264, 456);
            this.panel_goimon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng thanh toán:";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(177, 409);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Huỷ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(96, 409);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 38);
            this.button8.TabIndex = 6;
            this.button8.Text = "Sửa";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(15, 409);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 6;
            this.button6.Text = "Gọi món";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng";
            // 
            // sl
            // 
            this.sl.Location = new System.Drawing.Point(96, 58);
            this.sl.Name = "sl";
            this.sl.Size = new System.Drawing.Size(57, 22);
            this.sl.TabIndex = 4;
            this.sl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_dy
            // 
            this.btn_dy.Location = new System.Drawing.Point(161, 55);
            this.btn_dy.Name = "btn_dy";
            this.btn_dy.Size = new System.Drawing.Size(79, 26);
            this.btn_dy.TabIndex = 3;
            this.btn_dy.Text = "Đồng Ý";
            this.btn_dy.UseVisualStyleBackColor = true;
            this.btn_dy.Click += new System.EventHandler(this.btn_dy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tblmonanBindingSource;
            this.comboBox1.DisplayMember = "tenmon";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "tenmon";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn món";
            // 
            // lvOder
            // 
            this.lvOder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.tenmon,
            this.giamon,
            this.soluong,
            this.tong});
            this.lvOder.HideSelection = false;
            this.lvOder.Location = new System.Drawing.Point(6, 86);
            this.lvOder.Name = "lvOder";
            this.lvOder.Size = new System.Drawing.Size(255, 282);
            this.lvOder.TabIndex = 0;
            this.lvOder.UseCompatibleStateImageBehavior = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // tenmon
            // 
            this.tenmon.Text = "Tên Món";
            // 
            // giamon
            // 
            this.giamon.Text = "Giá Món";
            // 
            // soluong
            // 
            this.soluong.Text = "Số lượng";
            // 
            // tong
            // 
            this.tong.Text = "Tổng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_tongtt);
            this.panel1.Location = new System.Drawing.Point(114, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 22);
            this.panel1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "VNĐ";
            // 
            // txt_tongtt
            // 
            this.txt_tongtt.AutoSize = true;
            this.txt_tongtt.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_tongtt.Location = new System.Drawing.Point(0, 0);
            this.txt_tongtt.Name = "txt_tongtt";
            this.txt_tongtt.Size = new System.Drawing.Size(0, 16);
            this.txt_tongtt.TabIndex = 1;
            // 
            // tbl_monanTableAdapter
            // 
            this.tbl_monanTableAdapter.ClearBeforeFill = true;
            // 
            // frGoiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 456);
            this.Controls.Add(this.panel_goimon);
            this.Name = "frGoiMon";
            this.Text = "frGoiMon";
            this.Load += new System.EventHandler(this.frGoiMon_Load);
            this.panel_goimon.ResumeLayout(false);
            this.panel_goimon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblmonanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_goimon;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown sl;
        private System.Windows.Forms.Button btn_dy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvOder;
        private QuanNetDataSet quanNetDataSet;
        private System.Windows.Forms.BindingSource tblmonanBindingSource;
        private QuanNetDataSetTableAdapters.tbl_monanTableAdapter tbl_monanTableAdapter;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader tenmon;
        private System.Windows.Forms.ColumnHeader giamon;
        private System.Windows.Forms.ColumnHeader soluong;
        private System.Windows.Forms.ColumnHeader tong;
        private System.Windows.Forms.Label txt_tongtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}