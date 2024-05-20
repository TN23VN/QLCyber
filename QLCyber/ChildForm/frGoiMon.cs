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
    public partial class frGoiMon : Form
    {
        public frGoiMon()
        {
            InitializeComponent();
        }

        private void frGoiMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanNetDataSet.tbl_monan' table. You can move, or remove it, as needed.
            this.tbl_monanTableAdapter.Fill(this.quanNetDataSet.tbl_monan);

        }

        private void btn_dy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
