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
    public partial class frXoaMonAn : Form
    {
        public frXoaMonAn()
        {
            InitializeComponent();
        }

        private void frXoaMonAn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanNetDataSet.tbl_monan' table. You can move, or remove it, as needed.
            this.tbl_monanTableAdapter.Fill(this.quanNetDataSet.tbl_monan);

        }
    }
}
