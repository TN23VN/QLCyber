namespace QLCyber
{
    partial class frdsdm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb = new System.Windows.Forms.Label();
            this.txt_tientk = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sgdsd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sgcl = new System.Windows.Forms.TextBox();
            this.btn_dx = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tentk = new System.Windows.Forms.TextBox();
            this.quanNetDataSet1 = new QLCyber.QuanNetDataSet();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_dx);
            this.panel1.Controls.Add(this.txt_sgcl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_sgdsd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_tentk);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_tientk);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 450);
            this.panel1.TabIndex = 0;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(12, 63);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(124, 22);
            this.lb.TabIndex = 4;
            this.lb.Text = "Tiền tài khoản";
            // 
            // txt_tientk
            // 
            this.txt_tientk.Enabled = false;
            this.txt_tientk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tientk.Location = new System.Drawing.Point(173, 58);
            this.txt_tientk.Name = "txt_tientk";
            this.txt_tientk.Size = new System.Drawing.Size(161, 27);
            this.txt_tientk.TabIndex = 5;
            this.txt_tientk.TextChanged += new System.EventHandler(this.txt_tientk_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số giờ đã sử dụng";
            // 
            // txt_sgdsd
            // 
            this.txt_sgdsd.Enabled = false;
            this.txt_sgdsd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sgdsd.Location = new System.Drawing.Point(173, 103);
            this.txt_sgdsd.Name = "txt_sgdsd";
            this.txt_sgdsd.Size = new System.Drawing.Size(161, 27);
            this.txt_sgdsd.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số giờ còn lại";
            // 
            // txt_sgcl
            // 
            this.txt_sgcl.Enabled = false;
            this.txt_sgcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sgcl.Location = new System.Drawing.Point(173, 148);
            this.txt_sgcl.Name = "txt_sgcl";
            this.txt_sgcl.Size = new System.Drawing.Size(161, 27);
            this.txt_sgcl.TabIndex = 5;
            // 
            // btn_dx
            // 
            this.btn_dx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dx.Location = new System.Drawing.Point(235, 396);
            this.btn_dx.Name = "btn_dx";
            this.btn_dx.Size = new System.Drawing.Size(99, 42);
            this.btn_dx.TabIndex = 6;
            this.btn_dx.Text = "Đăng xuất";
            this.btn_dx.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên tài khoản";
            // 
            // txt_tentk
            // 
            this.txt_tentk.Enabled = false;
            this.txt_tentk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tentk.Location = new System.Drawing.Point(173, 12);
            this.txt_tentk.Name = "txt_tentk";
            this.txt_tentk.Size = new System.Drawing.Size(161, 27);
            this.txt_tentk.TabIndex = 5;
            // 
            // quanNetDataSet1
            // 
            this.quanNetDataSet1.DataSetName = "QuanNetDataSet";
            this.quanNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frdsdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frdsdm";
            this.Text = "frdsdm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanNetDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dx;
        private System.Windows.Forms.TextBox txt_sgcl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sgdsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tientk;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txt_tentk;
        private System.Windows.Forms.Label label3;
        private QuanNetDataSet quanNetDataSet1;
    }
}