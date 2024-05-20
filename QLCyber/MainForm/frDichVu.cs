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
    public partial class frDichVu : Form
    {
        public frDichVu()
        {
            InitializeComponent();
        }

        private void frDichVu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanNetDataSet.tbl_monan' table. You can move, or remove it, as needed.
            this.tbl_monanTableAdapter.Fill(this.quanNetDataSet.tbl_monan);

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

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frGoiMon());
        }

        private void btn_addFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frThemMon());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frSuaMon());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frXoaMonAn());
        }
    }
}
