using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLCyber
{
    public partial class frTTmay : Form
    {
        public frTTmay()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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
        private void motatmay(System.Windows.Forms.Button bt)
        {
            
            if (bt.BackColor == Color.Salmon)
                bt.BackColor = Color.PaleGreen;
            lb_somay.Text = bt.Text;
            OpenChildForm(new frlcm());
            /*/else
            {
                DialogResult dl = MessageBox.Show("Ban co muon tat may", "Canh bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                {
                    bt.BackColor = Color.Salmon;
                }
                else MessageBox.Show("Loi tat may");
            }/*/
        }


        private void button4_Click(object sender, EventArgs e)
        {
            motatmay(btnM1);
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            motatmay(btnM2);
        }

        private void btnM3_Click(object sender, EventArgs e)
        {
            motatmay(btnM3);
        }

        private void btnM4_Click(object sender, EventArgs e)
        {
            motatmay(btnM4);
        }

        private void btnM5_Click(object sender, EventArgs e)
        {
            motatmay(btnM5);
        }

        private void btnM7_Click(object sender, EventArgs e)
        {
            motatmay(btnM7);
        }

        private void btnM8_Click(object sender, EventArgs e)
        {
            motatmay(btnM8);
        }

        private void btnM9_Click(object sender, EventArgs e)
        {
            motatmay(btnM9);
        }

        private void btnM10_Click(object sender, EventArgs e)
        {
            motatmay(btnM10);
        }

        private void btnM6_Click(object sender, EventArgs e)
        {
            motatmay(btnM6);
        }

        private void btnM11_Click(object sender, EventArgs e)
        {
            motatmay(btnM11);
        }

        private void btnM12_Click(object sender, EventArgs e)
        {
            motatmay(btnM12);
        }

        private void btnM13_Click(object sender, EventArgs e)
        {
            motatmay(btnM13);
        }

        private void btnM14_Click(object sender, EventArgs e)
        {
            motatmay(btnM14);
        }

        private void btnM15_Click(object sender, EventArgs e)
        {
            motatmay(btnM15);
        }

        private void btnM16_Click(object sender, EventArgs e)
        {
            motatmay(btnM16);
        }

        private void btnM17_Click(object sender, EventArgs e)
        {
            motatmay(btnM17);
        }

        private void btnM18_Click(object sender, EventArgs e)
        {
            motatmay(btnM18);
        }

        private void btnM19_Click(object sender, EventArgs e)
        {
            motatmay(btnM19);
        }

        private void btnM20_Click(object sender, EventArgs e)
        {
            motatmay(btnM20);
        }
    }
}
