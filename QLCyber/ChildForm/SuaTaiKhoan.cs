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
    public partial class SuaTaiKhoan : Form
    {
        public SuaTaiKhoan()
        {
            InitializeComponent();
        }

        private void SuaTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanNetDataSet1.tbl_taikhoankhach' table. You can move, or remove it, as needed.
            this.tbl_taikhoankhachTableAdapter.Fill(this.quanNetDataSet1.tbl_taikhoankhach);

        }
    }
}
