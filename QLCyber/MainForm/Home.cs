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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild!=null)
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

        private void btn_dichvu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frDichVu());
        }

        private void btn_ttmay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frTTmay());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frTaiKhoan());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            panel_body.Controls.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frThongKe());
        }
    }
}
