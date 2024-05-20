namespace QLCyber
{
    partial class XoaTaiKhoan
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
            this.tbl_taikhoankhachTableAdapter = new QLCyber.QuanNetDataSet1TableAdapters.tbl_taikhoankhachTableAdapter();
            this.quanNetDataSet1 = new QLCyber.QuanNetDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbltaikhoankhachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_goimon = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaikhoankhachBindingSource)).BeginInit();
            this.panel_goimon.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl_taikhoankhachTableAdapter
            // 
            this.tbl_taikhoankhachTableAdapter.ClearBeforeFill = true;
            // 
            // quanNetDataSet1
            // 
            this.quanNetDataSet1.DataSetName = "QuanNetDataSet1";
            this.quanNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.tbltaikhoankhachBindingSource;
            this.comboBox1.DisplayMember = "TenTK";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(24, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "TenTK";
            // 
            // tbltaikhoankhachBindingSource
            // 
            this.tbltaikhoankhachBindingSource.DataMember = "tbl_taikhoankhach";
            this.tbltaikhoankhachBindingSource.DataSource = this.quanNetDataSet1;
            // 
            // panel_goimon
            // 
            this.panel_goimon.BackColor = System.Drawing.SystemColors.Control;
            this.panel_goimon.Controls.Add(this.comboBox1);
            this.panel_goimon.Controls.Add(this.button7);
            this.panel_goimon.Controls.Add(this.button8);
            this.panel_goimon.Controls.Add(this.label2);
            this.panel_goimon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_goimon.Location = new System.Drawing.Point(0, 0);
            this.panel_goimon.Name = "panel_goimon";
            this.panel_goimon.Size = new System.Drawing.Size(278, 450);
            this.panel_goimon.TabIndex = 5;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(156, 100);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 38);
            this.button7.TabIndex = 6;
            this.button7.Text = "Huỷ";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(64, 100);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 38);
            this.button8.TabIndex = 6;
            this.button8.Text = "Xoá";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản*:";
            // 
            // XoaTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 450);
            this.Controls.Add(this.panel_goimon);
            this.Name = "XoaTaiKhoan";
            this.Text = "XoaTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltaikhoankhachBindingSource)).EndInit();
            this.panel_goimon.ResumeLayout(false);
            this.panel_goimon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private QuanNetDataSet1TableAdapters.tbl_taikhoankhachTableAdapter tbl_taikhoankhachTableAdapter;
        private QuanNetDataSet1 quanNetDataSet1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource tbltaikhoankhachBindingSource;
        private System.Windows.Forms.Panel panel_goimon;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label2;
    }
}