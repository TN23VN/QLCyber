using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCyber
{
    public partial class frTaiKhoan : Form
    {
        public frTaiKhoan()
        {
            InitializeComponent();
        }

        private void frTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanNetDataSet1.tbl_taikhoankhach' table. You can move, or remove it, as needed.
            this.tbl_taikhoankhachTableAdapter.Fill(this.quanNetDataSet1.tbl_taikhoankhach);

        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_addTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TaoTaiKhoan());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SuaTaiKhoan());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new XoaTaiKhoan());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NapTienVaoTaiKhoan());
        }
    }
}
