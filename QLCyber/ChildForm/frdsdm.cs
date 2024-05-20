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
    public partial class frdsdm : Form
    {
        public frdsdm()
        {
            InitializeComponent();
        }

        private void txt_tientk_TextChanged(object sender, EventArgs e)
        {

        }

        public string _textBox { set { txt_tientk.Text = value; } }
    }
}
