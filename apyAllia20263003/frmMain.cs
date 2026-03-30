using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apyAllia20263003
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void btnContador_Click(object sender, EventArgs e)
        {

        }
    }
}
