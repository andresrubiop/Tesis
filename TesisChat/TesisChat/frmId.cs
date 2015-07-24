using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesisChat
{
    public partial class frmId : Form
    {
        public frmId()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmId_Load(object sender, EventArgs e)
        {

        }
        public TextBox TxtId
        {
            get
            {
                return txtId;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.Close();
            }
        }
    }
}
